using System;
using UnityEngine;

/// <summary>
/// <para>道具的创建信息，专门有个系统会处理这个创建信息，然后创建出道具的GameObject</para>
/// <para>所有脚本中，需要创建一个道具，也应该传递这个结构作为创建道具的参数</para>
/// </summary>
public class PropCreator
{
    /// <summary>
    /// 这是个什么道具
    /// </summary>
    public PropModel Model;

    /// <summary>
    /// 是否是一个消耗品，非消耗品的ConsumeTimes不会增加，即使=false，当使用次数达到上限后仍会被移除
    /// </summary>
    public bool IsConsumable;


    public PropCreator(PropModel model, bool isConsumable = true)
    {
        Model = model;
        IsConsumable = isConsumable;
    }
}

/// <summary>
/// 道具的模板数据
/// </summary>
public struct PropModel
{
    /// <summary>
    /// 道具的ID
    /// </summary>
    public string Id;

    /// <summary>
    /// 道具的名称（开发用）
    /// </summary>
    public string Name;

    /// <summary>
    /// 道具的tag
    /// </summary>
    public string[] Tags;

    /// <summary>
    /// 道具的最大使用次数
    /// </summary>
    public int MaxConsumeTimes;

    /// <summary>
    /// 道具的UI表现信息
    /// </summary>
    public PropUIInfo UIInfo;

    /// <summary>
    /// 道具在被选中时获得的buff，取消选择时移除buff，作为使用效果的buff不应该在这里
    /// </summary>
    public AddBuffInfo[] Buffs;

    /// <summary>
    /// 道具在被添加时触发的事件
    /// </summary>
    public PropOnCreate OnCreate;

    public object[] OnCreateArgs;

    /// <summary>
    /// 道具在被移除时触发的事件
    /// </summary>
    public PropOnRemove OnRemove;

    public object[] OnRemoveArgs;

    /// <summary>
    /// 道具在使用时触发的事件
    /// </summary>
    public PropOnConsume OnConsume;

    public object[] OnConsumeArgs;

    /// <summary>
    /// 道具在正常流程以外被移除时触发的事件
    /// </summary>
    public PropOnDestroy OnDestroy;

    public object[] OnDestroyArgs;

    public PropModel(string id, string name, string[] tags, int maxConsumeTimes,
        PropUIInfo uiInfo, AddBuffInfo[] buffs,
        string onCreate, object[] onCreateArgs,
        string onRemove, object[] onRemoveArgs,
        string onConsume, object[] onConsumeArgs,
        string onDestroy, object[] onDestroyArgs)
    {
        Id = id;
        Name = name;
        Tags = tags;
        MaxConsumeTimes = maxConsumeTimes;
        UIInfo = uiInfo;
        Buffs = buffs;

        OnCreate = string.IsNullOrEmpty(onCreate) ? null : DesignerScripts.Prop.OnCreateFunc[onCreate];
        OnCreateArgs = onCreateArgs ?? Array.Empty<object>();
        OnRemove = string.IsNullOrEmpty(onRemove) ? null : DesignerScripts.Prop.OnRemoveFunc[onRemove];
        OnRemoveArgs = onRemoveArgs ?? Array.Empty<object>();
        OnConsume = string.IsNullOrEmpty(onConsume) ? null : DesignerScripts.Prop.OnConsumeFunc[onConsume];
        OnConsumeArgs = onConsumeArgs ?? Array.Empty<object>();
        OnDestroy = string.IsNullOrEmpty(onDestroy) ? null : DesignerScripts.Prop.OnDestroyFunc[onDestroy];
        OnDestroyArgs = onDestroyArgs ?? Array.Empty<object>();
    }
}

/// <summary>
/// 道具的UI表现信息
/// </summary>
public struct PropUIInfo
{
    /// <summary>
    /// 道具的卡面材质资源ID
    /// </summary>
    public string TextureId;

    /// <summary>
    /// 道具的名称
    /// </summary>
    public string Title;

    /// <summary>
    /// 道具的描述
    /// </summary>
    public string Content;


    public PropUIInfo(string textureId, string title, string content)
    {
        TextureId = textureId;
        Title = title;
        Content = content;
    }
}

public delegate void PropOnCreate(GameObject prop);

public delegate void PropOnRemove(GameObject prop);

public delegate void PropOnConsume(GameObject prop);

public delegate void PropOnDestroy(GameObject prop);