using System;
using UnityEngine;

public class GameActionCreator
{
    public GameActionModel Model;

    public GameActionCreator(GameActionModel model)
    {
        Model = model;
    }
}

public struct GameActionModel
{
    public string Id;
    public string Name;
    public GameActionToEvent GameAction;
    public object[] GameActionArgs;

    public GameActionModel(string id, string name,
        string gameAction, object[] gameActionArgs)
    {
        Id = id;
        Name = name;
        GameAction = string.IsNullOrEmpty(gameAction) ? null : DesignerScripts.GameAction.ActionToEvent[gameAction];
        GameActionArgs = gameActionArgs ?? Array.Empty<object>();
    }
}

public delegate GameEventObject GameActionToEvent(GameObject action);