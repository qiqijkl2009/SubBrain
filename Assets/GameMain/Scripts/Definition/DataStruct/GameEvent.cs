using System;
using UnityEngine;

/// <summary>
/// 游戏中运行的事件实例
/// </summary>
public class GameEventObject
{
    /// <summary>
    /// 事件的model
    /// </summary>
    public GameEventModel Model;
    /// <summary>
    /// 事件的延迟回合数
    /// </summary>
    public int WaitRounds;
    /// <summary>
    /// 是否在事件移除时再添加一次同样的事件
    /// </summary>
    public bool IsRepeat;
    /// <summary>
    /// 是否只允许有且只有一个相同模板的事件存在
    /// </summary>
    public bool IsOnly;

    public GameEventObject(GameEventModel model, int waitRounds = 0, bool isRepeat = false, bool isOnly = false)
    {
        Model = model;
        WaitRounds = waitRounds;
        IsRepeat = isRepeat;
        IsOnly = isOnly;
    }
}

/// <summary>
/// 事件的模板数据
/// </summary>
public struct GameEventModel
{
    /// <summary>
    /// 事件的id
    /// </summary>
    public string Id;
    /// <summary>
    /// 事件的名称
    /// </summary>
    public string Name;
    /// <summary>
    /// 事件的tags
    /// </summary>
    public string[] Tags;
    /// <summary>
    /// 事件附带的行动
    /// </summary>
    public GameActionModel[] GameActions;
    /// <summary>
    /// 事件的UI表现信息
    /// </summary>
    public GameEventUIInfo UIInfo;

    public string AudioId;

    /// <summary>
    /// 游戏事件在被添加时触发的事件
    /// </summary>
    public GameEventOnCreate OnCreate;
    public object[] OnCreateArgs;
    /// <summary>
    /// 游戏事件在进入时触发的事件
    /// </summary>
    public GameEventOnEnter OnEnter;
    public object[] OnEnterArgs;
    /// <summary>
    /// 游戏事件在被移除时触发的事件
    /// </summary>
    public GameEventOnLeave OnLeave;
    public object[] OnLeaveArgs;

    public GameEventModel(string id, string name, string[] tags, GameActionModel[] gameActions, GameEventUIInfo uiInfo, string audioId,
        string onCreate, object[] onCreateArgs,
        string onEnter, object[] onEnterArgs,
        string onLeave, object[] onLeaveArgs)
    {
        Id = id;
        Name = name;
        Tags = tags;
        GameActions = gameActions;
        UIInfo = uiInfo;
        AudioId = audioId;
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