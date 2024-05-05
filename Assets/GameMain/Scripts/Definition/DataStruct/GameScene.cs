using System;
using UnityEngine;

/// <summary>
/// <para>场景卡的创建信息，专门有个系统会处理这个创建信息，然后创建出场景卡的GameObject</para>
/// <para>所有脚本中，需要创建一个场景卡，也应该传递这个结构作为创建场景卡的参数</para>
/// </summary>
public class GameSceneCreator
{
    /// <summary>
    /// 场景的model
    /// </summary>
    public GameSceneModel Model;

    public GameSceneCreator(GameSceneModel model)
    {
        Model = model;
    }
}

/// <summary>
/// 场景的模板数据
/// </summary>
public struct GameSceneModel
{
    /// <summary>
    /// 场景的id
    /// </summary>
    public string Id;

    /// <summary>
    /// 场景的名称
    /// </summary>
    public string Name;

    /// <summary>
    /// 进入场景的事件
    /// </summary>
    public GameEventModel GameEvent;

    /// <summary>
    /// 场景附带的buff
    /// </summary>
    public AddBuffInfo[] Buffs;

    /// <summary>
    /// 场景在被添加时触发的事件
    /// </summary>
    public GameSceneOnCreate OnCreate;

    public object[] OnCreateArgs;

    /// <summary>
    /// 场景在被移出时触发的事件
    /// </summary>
    public GameSceneOnRemove OnRemove;

    public object[] OnRemoveArgs;

    /// <summary>
    /// 场景在被选为行动时触发的事件
    /// </summary>
    public GameSceneOnSelect OnSelect;

    public object[] OnSelectArgs;

    public GameSceneModel(string id, string name, GameEventModel gameEvent, AddBuffInfo[] buffs,
        string onCreate, object[] onCreateArgs,
        string onRemove, object[] onRemoveArgs,
        string onSelect, object[] onSelectArgs)
    {
        Id = id;
        Name = name;
        GameEvent = gameEvent;
        Buffs = buffs;

        OnCreate = string.IsNullOrEmpty(onCreate) ? null : DesignerScripts.GameScene.OnCreateFunc[onCreate];
        OnCreateArgs = onCreateArgs ?? Array.Empty<object>();
        OnRemove = string.IsNullOrEmpty(onRemove) ? null : DesignerScripts.GameScene.OnRemoveFunc[onRemove];
        OnRemoveArgs = onRemoveArgs ?? Array.Empty<object>();
        OnSelect = string.IsNullOrEmpty(onSelect) ? null : DesignerScripts.GameScene.OnSelectFunc[onSelect];
        OnSelectArgs = onSelectArgs ?? Array.Empty<object>();
    }
}

public delegate void GameSceneOnCreate(GameObject scene);

public delegate void GameSceneOnRemove(GameObject scene);

public delegate void GameSceneOnSelect(GameObject scene);