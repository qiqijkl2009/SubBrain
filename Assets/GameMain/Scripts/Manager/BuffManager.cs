using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BuffManager : MonoBehaviour
{
    private static BuffManager _instance;

    public static void Init()
    {
        _instance = ManagerRoot.RootTransform.GetComponentInChildren<BuffManager>();
    }

    private readonly List<BuffObject> _buffs = new();

    /// <summary>
    /// 当前的Buff列表
    /// </summary>
    public static List<BuffObject> Buffs => _instance._buffs;


    /// <summary>
    /// Buff结算更新流程
    /// </summary>
    /// <param name="roundCount">经过的回合数</param>
    public static void BuffUpdate(int roundCount)
    {
        var toRemove = new List<BuffObject>();

        foreach (var buff in Buffs)
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

        if (toRemove.Count > 0)
        {
            foreach (var buff in toRemove)
            {
                Buffs.Remove(buff);
            }
        }

        toRemove = null;
    }

    /// <summary>
    /// 为角色添加buff，删除buff也是走这个的，只不过删除的流程不在这里处理
    /// </summary>
    /// <param name="buff">要改变的Buff</param>
    public static void AddBuff(AddBuffInfo buff)
    {
        var buffSource = new List<GameObject>();
        if (buff.Source)
        {
            buffSource.Add(buff.Source);
        }

        var existBuffs = GetBuffById(buff.BuffModel.Id, buffSource);
        int modStack = Mathf.Min(buff.AddStack, buff.BuffModel.MaxStack);

        var toAddBuff = existBuffs.Count > 0
            ? MergeSameBuff(buff, existBuffs[0], out modStack) //存在id相同且来源相同的buff
            : CreateNewBuff(buff); //不存在id相同且来源相同的buff

        if (toAddBuff.Stack > 0)
        {
            buff.BuffModel.OnOccur?.Invoke(toAddBuff, modStack);
        }
    }

    private static BuffObject MergeSameBuff(AddBuffInfo newBuff, BuffObject existBuff, out int modStack)
    {
        existBuff.BuffArgs = new Dictionary<string, object>();
        if (newBuff.BuffArgs != null)
        {
            foreach (var kvp in newBuff.BuffArgs)
            {
                existBuff.BuffArgs[kvp.Key] = kvp.Value;
            }
        }

        existBuff.Duration = newBuff.DurationSetTo ? newBuff.Duration : newBuff.Duration + existBuff.Duration;
        existBuff.Permanent = newBuff.Permanent;

        int afterAdd = existBuff.Stack + newBuff.AddStack;
        if (afterAdd >= existBuff.Model.MaxStack)
        {
            modStack = existBuff.Model.MaxStack - existBuff.Stack;
        }
        else if (afterAdd <= 0)
        {
            modStack = -existBuff.Stack;
        }
        else
        {
            modStack = newBuff.AddStack;
        }

        existBuff.Stack += modStack;

        return existBuff;
    }

    private static BuffObject CreateNewBuff(AddBuffInfo buff)
    {
        var newBuff = new BuffObject
        (
            buff.BuffModel,
            buff.Source,
            buff.Duration,
            buff.AddStack,
            buff.Permanent,
            buff.BuffArgs
        );

        if (buff.AddStack >= buff.BuffModel.MaxStack)
        {
            newBuff.Stack = buff.BuffModel.MaxStack;
        }
        else if (buff.AddStack < 0)
        {
            newBuff.Stack = 0;
        }

        if (newBuff.Stack > 0)
        {
            Buffs.Add(newBuff);
            Buffs.Sort((a, b) => b.Model.Priority.CompareTo(a.Model.Priority));
        }

        return newBuff;
    }


    ///<summary>
    ///获取角色身上对应的BuffObject
    ///<param name="id">Buff的Model的Id</param>
    ///<param name="source">如果source不为空，那么就代表只有BuffObject.Source在source里面的才符合条件</param>
    ///<return>符合条件的BuffObject数组</return>
    ///</summary>
    public static List<BuffObject> GetBuffById(string id, List<GameObject> source = null)
    {
        return Buffs.Where(buff => IsBuffFromSource(buff, id, source)).ToList();
    }

    private static bool IsBuffFromSource(BuffObject buff, string id, List<GameObject> source)
    {
        return buff.Model.Id == id && (source is not { Count: > 0 } || source.Contains(buff.Source));
    }
}