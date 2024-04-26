using System.Collections.Generic;
using UnityEngine;

public class RoundManager : MonoBehaviour
{
    private static RoundManager _instance;

    public static void Init()
    {
        _instance = ManagerRoot.RootTransform.GetComponentInChildren<RoundManager>();
    }


    /// <summary>
    /// 回合开始流程
    /// </summary>
    public static void RoundStart()
    {
        
    }
    
    /// <summary>
    /// 回合结束流程
    /// </summary>
    /// <param name="roundCount">经过的回合数</param>
    public static void RoundOver(int roundCount = 1)
    {
        //事件管理
        var gameEventList = ManagerVariant.GameEvents();
        
        //buff管理
        var buffList = ManagerVariant.Buffs();
        var toRemove = new List<BuffObject>();

        foreach (var buff in buffList)
        {
            if (!buff.Permanent) buff.Duration -= roundCount;
            buff.TimeElapsed += roundCount;

            if (buff.Model is { TickTime: > 0, OnTick: not null })
            {
                if (buff.TimeElapsed % buff.Model.TickTime == 0)
                {
                    buff.Model.OnTick.Invoke(buff);
                    buff.Ticked += 1;
                }
            }

            //只要duration <= 0，不管是否是permanent都移除掉
            if (buff.Duration <= 0 || buff.Stack <= 0)
            {
                buff.Model.OnRemove?.Invoke(buff);
                toRemove.Add(buff);
            }
        }

        if (toRemove.Count <= 0) return;

        foreach (var buff in toRemove)
        {
            buffList.Remove(buff);
        }

        toRemove = null;
    }
}