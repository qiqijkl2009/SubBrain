using System;
using UnityEngine;

public class GameEventObject
{
    public GameEventModel Model;
    public int WaitRounds;
    public bool IsRepeat;
    public bool IsOnly;

    public GameEventObject(GameEventModel model, int waitRounds = 0, bool isRepeat = false, bool isOnly = false)
    {
        Model = model;
        WaitRounds = waitRounds;
        IsRepeat = isRepeat;
        IsOnly = isOnly;
    }
}

public struct GameEventModel
{
    public string Id;
    public string Name;
    public string[] Tags;
    public GameActionModel[] GameActions;

    public GameEventUIInfo UIInfo;

    public GameEventOnCreate OnCreate;
    public object[] OnCreateArgs;
    public GameEventOnEnter OnEnter;
    public object[] OnEnterArgs;
    public GameEventOnLeave OnLeave;
    public object[] OnLeaveArgs;

    public GameEventModel(string id, string name, string[] tags, GameActionModel[] gameActions, GameEventUIInfo uiInfo,
        string onCreate, object[] onCreateArgs,
        string onEnter, object[] onEnterArgs,
        string onLeave, object[] onLeaveArgs)
    {
        Id = id;
        Name = name;
        Tags = tags;
        GameActions = gameActions;
        UIInfo = uiInfo;
        GameActions = new GameActionModel[2];
        if (gameActions != null)
        {
            for (int i = 0; i < Mathf.Min(2, gameActions.Length); i++)
            {
                GameActions[i] = gameActions[i];
            }
        }

        OnCreate = string.IsNullOrEmpty(onCreate) ? null : DesignerScripts.GameEvent.OnCreateFunc[onCreate];
        OnCreateArgs = onCreateArgs ?? Array.Empty<object>();
        OnEnter = string.IsNullOrEmpty(onEnter) ? null : DesignerScripts.GameEvent.OnEnterFunc[onEnter];
        OnEnterArgs = onEnterArgs ?? Array.Empty<object>();
        OnLeave = string.IsNullOrEmpty(onLeave) ? null : DesignerScripts.GameEvent.OnLeaveFunc[onLeave];
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

public delegate void GameEventOnCreate(GameEventObject gameEventObject);

public delegate void GameEventOnEnter(GameEventObject gameEventObject);

public delegate void GameEventOnLeave(GameEventObject gameEventObject);