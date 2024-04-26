using System;
using System.Collections.Generic;
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
        private set => _instance._currentGameEvent = value;
    }

    public static GameObject[] GameActions => _instance._gameActions;

    private bool _isRoundNotEnd = false;

    private void FixedUpdate()
    {
        while (_gameEvents.Count > 0)
        {
            if (_isRoundNotEnd) return;
            EnterGameEvent(_gameEvents[0]);
        }
    }


    /// <summary>
    /// 添加一个GameEvent
    /// </summary>
    /// <param name="model">游戏事件模板</param>
    /// <param name="waitRounds">等待回合数</param>
    /// <param name="isRepeat">是否循环</param>
    /// <param name="isOnly">是否唯一</param>
    public static void CreateGameEvent(GameEventModel model, int waitRounds = 0, bool isRepeat = false, bool isOnly = false)
    {
        var gameEvent = new GameEventObject();
        CreateGameEvent(gameEvent);
    }

    /// <summary>
    /// 添加一个GameEvent
    /// </summary>
    /// <param name="gameEvent">游戏事件实例</param>
    public static void CreateGameEvent(GameEventObject gameEvent)
    {
        GameEvents.Add(gameEvent);
        gameEvent.Model.OnCreate?.Invoke(gameEvent);
    }

    /// <summary>
    /// 进入处理GameEventObject的流程
    /// </summary>
    /// <param name="gameEvent">游戏事件对象</param>
    private static void EnterGameEvent(GameEventObject gameEvent)
    {
        CurrentGameEvent = gameEvent;
        _instance._isRoundNotEnd = true;
        //需要UI那边给接口，这里是伪代码
        //EventPanel.ShowEvent(gameEvent.Model.UIInfo);

        gameEvent.Model.OnEnter?.Invoke(gameEvent);
    }

    /// <summary>
    /// 退出处理GameEventObject的流程
    /// </summary>
    private static void LeaveGameEvent()
    {
        CurrentGameEvent.Model.OnLeave?.Invoke(CurrentGameEvent);

        GameEvents.Remove(CurrentGameEvent);
        if (CurrentGameEvent.IsRepeat)
        {
            CreateGameEvent(CurrentGameEvent.Model);
        }

        CurrentGameEvent = null;
        Array.Clear(GameActions, 0, GameActions.Length);
    }

    private static void CreateGameAction(GameActionCreator gameActionCreator)
    {
        // GameObject gameActionObject = Instantiate();
        // gameActionObject.GetComponent<ActionState>().InitByGameActionCreator(gameActionCreator);
    }
}