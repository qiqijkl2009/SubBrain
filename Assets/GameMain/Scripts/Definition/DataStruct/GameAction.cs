using System;
using UnityEngine;

/// <summary>
/// <para>行动的创建信息，专门有个系统会处理这个创建信息，然后创建出行动卡的GameObject</para>
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
    /// 行动的UI表现信息
    /// </summary>
    public GameEventUIInfo UIInfo;

    /// <summary>
    /// 行动的对应事件判定方法
    /// </summary>
    public GameActionToEvent GameAction;

    public object[] GameActionArgs;

    public GameActionModel(string id, string name, GameEventUIInfo uiInfo,
        string gameAction, object[] gameActionArgs)
    {
        Id = id;
        Name = name;
        UIInfo = uiInfo;

        GameAction = string.IsNullOrEmpty(gameAction) ? null : DesignerScripts.GameAction.ActionToEvent[gameAction];
        GameActionArgs = gameActionArgs ?? Array.Empty<object>();
    }
}

/// <summary>
/// 行动的UI表现信息
/// </summary>
public struct GameActionUIInfo
{
    /// <summary>
    /// 行动的卡面材质资源ID
    /// </summary>
    public string TextureId;

    /// <summary>
    /// 行动的名称
    /// </summary>
    public string Title;

    /// <summary>
    /// 行动的内容
    /// </summary>
    public string Content;


    public GameActionUIInfo(string textureId, string title, string content)
    {
        TextureId = textureId;
        Title = title;
        Content = content;
    }
}

public delegate GameEventObject GameActionToEvent(GameObject action);