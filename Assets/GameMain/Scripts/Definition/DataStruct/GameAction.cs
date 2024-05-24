using System;
using UnityEngine;

/// <summary>
/// <para>行动卡的创建信息，专门有个系统会处理这个创建信息，然后创建出行动卡的GameObject</para>
/// <para>所有脚本中，需要创建一个行动卡，也应该传递这个结构作为创建行动卡的参数</para>
/// </summary>
public class GameActionCreator
{
    /// <summary>
    /// 行动的model
    /// </summary>
    public GameActionModel Model;

    public GameActionCreator(GameActionModel model)
    {
        Model = model;
    }
}

/// <summary>
/// 行动的模板数据
/// </summary>
public struct GameActionModel
{
    /// <summary>
    /// 行动的id
    /// </summary>
    public string Id;

    /// <summary>
    /// 行动的名称
    /// </summary>
    public string Name;

    /// <summary>
    /// 行动对角色资源的改变值
    /// </summary>
    public CharacterResource ModResource;

    /// <summary>
    /// 行动对角色资源的需求值
    /// </summary>
    public CharacterResource Requirement;

    /// <summary>
    /// 行动的UI表现信息
    /// </summary>
    public GameActionUIInfo UIInfo;

    /// <summary>
    /// 行动的对应事件判定方法
    /// </summary>
    public GameActionToEvent ToEvent;

    public object[] ToEventArgs;

    /// <summary>
    /// 行动的额外效果
    /// </summary>
    public GameActionExtra Extra;

    public object[] ExtraArgs;

    public GameActionModel(string id, string name, CharacterResource modResource, CharacterResource requirement, 
        GameActionUIInfo uiInfo,
        string toEvent, object[] toEventArgs,
        string extra, object[] extraArgs)
    {
        Id = id;
        Name = name;
        ModResource = modResource;
        Requirement = requirement;
        UIInfo = uiInfo;

        ToEvent = string.IsNullOrEmpty(toEvent) ? null : DesignerScripts.GameAction.ToEvent[toEvent];
        ToEventArgs = toEventArgs ?? Array.Empty<object>();
        Extra = string.IsNullOrEmpty(extra) ? null : DesignerScripts.GameAction.Extra[extra];
        ExtraArgs = extraArgs ?? Array.Empty<object>();
    }
}

/// <summary>
/// 行动的UI表现信息
/// </summary>
public struct GameActionUIInfo
{
    /// <summary>
    /// 行动的名称
    /// </summary>
    public string Title;
    
    public GameActionUIInfo(string title)
    {
        Title = title;
    }
}

public delegate GameEventObject GameActionToEvent(GameObject action, int waitRounds, bool isRepeat, bool isOnly);

public delegate void GameActionExtra(GameObject action);