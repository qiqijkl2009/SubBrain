using System;
using UnityEngine;

public class GameSceneCreator
{
    public GameSceneModel Model;

    public GameSceneCreator(GameSceneModel model)
    {
        Model = model;
    }
}

public struct GameSceneModel
{
    public string Id;
    public string Name;
    public GameEventModel GameEvent;
    public AddBuffInfo[] Buffs;

    public GameSceneOnCreate OnCreate;
    public object[] OnCreateArgs;
    public GameSceneOnRemove OnRemove;
    public object[] OnRemoveArgs;
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