using System;
using UnityEngine;

public struct AddGameEventInfo
{
    public GameEventModel Model;
    public int WaitRounds;
    public bool IsRepeat;
    public bool IsOnly;
}

public class GameEvent
{
    public GameEventModel Model;
    public int RestWaitRounds;
    public bool IsRepeat;
    public bool IsOnly;
}

public struct GameEventModel
{
    public string Id;
    public string Name;
    public string[] Tags;

    public GameEventUIInfo UIInfo;

    public GameEventOnCreate OnCreate;
    public object[] OnCreateArgs;
    public GameEventOnEnter OnEnter;
    public object[] OnEnterArgs;
    public GameEventOnLeave OnLeave;
    public object[] OnLeaveArgs;

    public GameEventModel(string id, string name, string[] tags, GameEventUIInfo uiInfo,
        string onCreate, object[] onCreateArgs,
        string onEnter, object[] onEnterArgs,
        string onLeave, object[] onLeaveArgs)
    {
        Id = id;
        Name = name;
        Tags = tags;
        UIInfo = uiInfo;

        OnCreate = onCreate == "" ? null : DesignerScripts.GameEvent.OnCreateFunc[onCreate];
        OnCreateArgs = onCreateArgs ?? Array.Empty<object>();
        OnEnter = onEnter == "" ? null : DesignerScripts.GameEvent.OnEnterFunc[onEnter];
        OnEnterArgs = onEnterArgs ?? Array.Empty<object>();
        OnLeave = onLeave == "" ? null : DesignerScripts.GameEvent.OnLeaveFunc[onLeave];
        OnLeaveArgs = onLeaveArgs ?? Array.Empty<object>();
    }
}

/// <summary>
/// 事件的UI表现信息
/// </summary>
public struct GameEventUIInfo
{
    /// <summary>
    /// 事件的卡面材质资源ID
    /// </summary>
    public string TextureId;

    /// <summary>
    /// 事件的名称
    /// </summary>
    public string Title;

    /// <summary>
    /// 事件的内容
    /// </summary>
    public string Content;


    public GameEventUIInfo(string textureId, string title, string content)
    {
        TextureId = textureId;
        Title = title;
        Content = content;
    }
}

public delegate void GameEventOnCreate(GameEvent gameEvent);

public delegate void GameEventOnEnter(GameEvent gameEvent);

public delegate void GameEventOnLeave(GameEvent gameEvent);