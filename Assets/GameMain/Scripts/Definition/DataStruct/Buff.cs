using System;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 用于添加一条buff的信息
/// </summary>
public struct AddBuffInfo
{
    /// <summary>
    /// buff的model，这里当然可以从数据里拿，也可以是逻辑脚本现生成的
    /// </summary>
    public BuffModel BuffModel;

    /// <summary>
    /// buff的来源是谁，可以是null
    /// </summary>
    public GameObject Source;

    /// <summary>
    /// 要添加的层数，负数则为减少
    /// </summary>
    public int AddStack;

    /// <summary>
    /// 是否是一个永久buff，永久buff的duration不会减少，即使=true，当时间被减少到0以下时仍会被删除
    /// </summary>
    public bool Permanent;

    /// <summary>
    /// 关于时间，是改变还是设置为, true代表设置为，false代表改变
    /// </summary>
    public bool DurationSetTo;

    /// <summary>
    /// 时间值，设置为这个值，或者加上这个值，单位：回合
    /// </summary>
    public int Duration;

    /// <summary>
    /// buff的一些参数，这些参数是逻辑使用的
    /// </summary>
    public Dictionary<string, object> BuffArgs;


    public AddBuffInfo(BuffModel model, GameObject source, int addStack, int duration,
        bool durationSetTo = false,
        bool permanent = false,
        Dictionary<string, object> buffArgs = null)
    {
        BuffModel = model;
        Source = source;
        AddStack = addStack;
        Duration = duration;
        DurationSetTo = durationSetTo;
        Permanent = permanent;
        BuffArgs = buffArgs;
    }

    public AddBuffInfo Opposite()
    {
        var opposite = this;
        opposite.AddStack = -AddStack;
        return opposite;
    }
}

/// <summary>
/// 游戏中运行的、角色身上存在的buff
/// </summary>
public class BuffObject
{
    /// <summary>
    /// 这是个什么buff
    /// </summary>
    public BuffModel Model;

    /// <summary>
    /// 剩余多久，单位：回合
    /// </summary>
    public int Duration;

    /// <summary>
    /// 是否是一个永久buff，永久buff的duration不会减少，即使=true，当时间被减少到0以下时仍会被删除
    /// </summary>
    public bool Permanent;

    /// <summary>
    /// 当前层数
    /// </summary>
    public int Stack;

    /// <summary>
    /// buff的来源是谁，可以是null
    /// </summary>
    public GameObject Source;

    /// <summary>
    /// buff已经存在了多少时间了，单位：回合
    /// </summary>
    public int TimeElapsed = 0;

    /// <summary>
    /// buff执行了多少次onTick了，如果不会执行onTick，那将永远是0
    /// </summary>
    public int Ticked = 0;

    /// <summary>
    /// buff的一些参数，这些参数是逻辑使用的
    /// </summary>
    public Dictionary<string, object> BuffArgs = new();


    public BuffObject(BuffModel model, GameObject source, int duration, int stack,
        bool permanent = false,
        Dictionary<string, object> buffParam = null)
    {
        Model = model;
        Source = source;
        Duration = duration;
        Stack = stack;
        Permanent = permanent;
        if (buffParam != null)
        {
            foreach (var kvp in buffParam)
            {
                BuffArgs.Add(kvp.Key, kvp.Value);
            }
        }
    }
}

/// <summary>
/// buff的模板数据
/// </summary>
public struct BuffModel
{
    /// <summary>
    /// buff的id
    /// </summary>
    public string Id;

    /// <summary>
    /// buff的名称
    /// </summary>
    public string Name;

    /// <summary>
    /// buff的优先级，优先级越低的buff越后面执行
    /// </summary>
    public int Priority;

    /// <summary>
    /// buff的最大堆叠层数，只要id和caster相同的buffObj就可以堆叠
    /// </summary>
    public int MaxStack;

    /// <summary>
    /// buff的tag
    /// </summary>
    public string[] Tags;

    /// <summary>
    /// <para>buff的工作周期，单位：回合</para>
    /// <para>每多少回合执行一次，如果&lt;=0 则代表不会周期性工作，只要>0，则最小值为1</para>
    /// </summary>
    public int TickTime;

    /// <summary>
    /// buff在被添加、改变层数时触发的事件
    /// </summary>
    public BuffOnOccur OnOccur;

    public object[] OnOccurArgs;

    /// <summary>
    /// buff在被移除时触发的事件
    /// </summary>
    public BuffOnRemove OnRemove;

    public object[] OnRemoveArgs;

    /// <summary>
    /// buff在每个工作周期会触发的事件
    /// </summary>
    public BuffOnTick OnTick;

    public object[] OnTickArgs;

    /// <summary>
    /// buff在游戏结束前触发的事件
    /// </summary>
    public BuffOnBeforeDead OnBeforeDead;

    public object[] OnBeforeDeadArgs;


    public BuffModel(string id, string name, int priority, int maxStack, string[] tags, int tickTime,
        string onOccur, object[] onOccurArgs,
        string onRemove, object[] onRemoveArgs,
        string onTick, object[] onTickArgs,
        string onBeforeDead, object[] onBeforeDeadArgs)
    {
        Id = id;
        Name = name;
        Priority = priority;
        MaxStack = maxStack;
        Tags = tags;
        TickTime = tickTime;

        OnOccur = string.IsNullOrEmpty(onOccur) ? null : DesignerScripts.Buff.OnOccurFunc[onOccur];
        OnOccurArgs = onOccurArgs ?? Array.Empty<object>();
        OnRemove = string.IsNullOrEmpty(onRemove) ? null : DesignerScripts.Buff.OnRemoveFunc[onRemove];
        OnRemoveArgs = onRemoveArgs ?? Array.Empty<object>();
        OnTick = string.IsNullOrEmpty(onTick) ? null : DesignerScripts.Buff.OnTickFunc[onTick];
        OnTickArgs = onTickArgs ?? Array.Empty<object>();
        OnBeforeDead = string.IsNullOrEmpty(onBeforeDead) ? null : DesignerScripts.Buff.OnBeforeDeadFunc[onBeforeDead];
        OnBeforeDeadArgs = onBeforeDeadArgs ?? Array.Empty<object>();
    }
}

public delegate void BuffOnOccur(BuffObject buff, int modStack);

public delegate void BuffOnRemove(BuffObject buff);

public delegate void BuffOnTick(BuffObject buff);

public delegate void BuffOnBeforeDead(BuffObject buff);