using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameEventManager : MonoBehaviour
{
    private static GameEventManager _instance;

    public static void Init()
    {
        _instance = ManagerRoot.RootTransform.GetComponentInChildren<GameEventManager>();
    }

    private readonly List<GameEventObject> _gameEvents = new();
    private GameEventObject _currentGameEvent = null;
    private readonly GameObject[] _gameActions = new GameObject[2];

    public static List<GameEventObject> GameEvents => _instance._gameEvents;

    public static GameEventObject CurrentGameEvent
    {
        get => _instance._currentGameEvent; 
        set => _instance._currentGameEvent = value;
    }

    public static GameObject[] GameActions => _instance._gameActions;


    /// <summary>
    /// 添加一个GameEvent至列表
    /// </summary>
    /// <param name="model">游戏事件模板</param>
    /// <param name="waitRounds">等待回合数</param>
    /// <param name="isRepeat">是否循环</param>
    /// <param name="isOnly">是否唯一</param>
    public static void CreateGameEvent(GameEventModel model, int waitRounds = 0, bool isRepeat = false, bool isOnly = false)
    {
        var gameEvent = new GameEventObject(model, waitRounds, isRepeat, isOnly);
        CreateGameEvent(gameEvent);
    }

    /// <summary>
    /// 添加一个GameEvent至列表
    /// </summary>
    /// <param name="gameEvent">游戏事件实例</param>
    public static void CreateGameEvent(GameEventObject gameEvent)
    {
        if (gameEvent.IsOnly && GameEvents.Any(e => e.Model.Id == gameEvent.Model.Id)) return;

        GameEvents.Add(gameEvent);
        gameEvent.Model.OnCreate?.Invoke(gameEvent);
    }


    public static GameObject CreateGameAction(GameActionCreator action)
    {
        //TODO:换预制体
        var actionObject = R.Test.TestPropCard_GameObject();
        var actionState = actionObject.GetComponent<ActionState>();

        actionState.InitByGameActionCreator(action);

        if (GameActions[0] is null)
        {
            GameActions[0] = actionObject;
        }
        else
        {
            GameActions[1] = actionObject;
        }

        return actionObject;
    }
}