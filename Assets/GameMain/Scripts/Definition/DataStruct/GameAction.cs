using UnityEngine;

public class GameActionCreator
{
    public GameActionModel Model;
    public GameActionToEvent GameActionOverride;
}

public struct GameActionModel
{
    public string Id;
    public string Name;
    public GameActionToEvent GameAction;
}

public delegate GameEventObject GameActionToEvent(GameObject action);