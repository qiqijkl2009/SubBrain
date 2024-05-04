using System;
using System.Collections.Generic;
using System.Linq;
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
        //事件进入流程
        var gameEvents = ManagerVariant.GameEvents();
        var currentGameEvent = ManagerVariant.CurrentGameEvent();
        
        var toEnter = gameEvents.Where(e => e.WaitRounds == 0).ToList();

        if (toEnter.Count > 0)
        {
            currentGameEvent = toEnter[0];
        }
        else
        {
            //让玩家自由行动
            return;
        }
        
        foreach (var eventObject in gameEvents.Where(e => e.WaitRounds > 0))
        {
            eventObject.WaitRounds--;
        }

        currentGameEvent.Model.OnEnter?.Invoke(currentGameEvent);
        foreach (var action in currentGameEvent.Model.GameActions)
        {
            var actionCard = ManagerVariant.CreateGameAction(new GameActionCreator(action));
            
            //传递给UI，事件or接口调用，把这些行动传过去
        }
    }

    /// <summary>
    /// 回合结束流程
    /// </summary>
    /// <param name="roundCount">经过的回合数</param>
    public static void RoundOver(int roundCount = 1)
    {
        //事件退出流程
        var gameEvents = ManagerVariant.GameEvents();
        var gameActions = ManagerVariant.GameActions();
        var currentGameEvent = ManagerVariant.CurrentGameEvent();

        currentGameEvent.Model.OnLeave?.Invoke(currentGameEvent);
        gameEvents.Remove(currentGameEvent);

        if (currentGameEvent.IsRepeat)
        {
            ManagerVariant.CreateGameEvent(currentGameEvent.Model);
        }

        currentGameEvent = null;
        Array.Clear(gameActions, 0, gameActions.Length);

        //buff结算流程
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

        RoundStart();
    }
}