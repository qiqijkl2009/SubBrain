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

    public static List<BuffObject> Buffs => _instance._buffs;


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

        if (existBuffs[0].Stack > 0)
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
        Buffs.Add(newBuff);
        Buffs.Sort((a, b) => b.Model.Priority.CompareTo(a.Model.Priority));

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