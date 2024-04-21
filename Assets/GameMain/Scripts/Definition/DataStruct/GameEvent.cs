using System;
using UnityEngine;
using UnityEngine.Serialization;

public struct AddGameEventInfo
{
    public GameEventModel Model;
    public GameObject Source;
}

public class GameEvent
{
    public GameEventModel Model;
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

public struct GameEventUIInfo
{
    public string TextureId;
    public string Title;
    public string Content;
}

public delegate void GameEventOnCreate(GameEvent gameEvent);

public delegate void GameEventOnEnter(GameEvent gameEvent);

public delegate void GameEventOnLeave(GameEvent gameEvent);