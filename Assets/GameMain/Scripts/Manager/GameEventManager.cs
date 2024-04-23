using System.Collections.Generic;
using UnityEngine;

public class GameEventManager : MonoBehaviour
{
    private static GameEventManager _instance;

    public static void Init()
    {
        _instance = ManagerRoot.RootTransform.GetComponentInChildren<GameEventManager>();
    }

    private readonly List<GameEvent> _gameEventObjects = new();
    private bool _isRoundNotEnd = false;

    private void FixedUpdate()
    {
        while (_gameEventObjects.Count > 0)
        {
            if (_isRoundNotEnd) return;
            EnterGameEvent(_gameEventObjects[0]);
        }
    }


    /// <summary>
    /// 进入处理GameEventObject的流程
    /// </summary>
    /// <param name="gEvent">游戏事件对象</param>
    private static void EnterGameEvent(GameEvent gEvent)
    {
        _instance._isRoundNotEnd = true;
        //需要UI那边给接口，这里是伪代码
        //EventPanel.ShowEvent(gEvent);

        gEvent.Model.OnEnter?.Invoke(gEvent);
    }

    /// <summary>
    /// 退出处理GameEventObject的流程
    /// </summary>
    private static void LeaveGameEvent()
    {
        _instance._gameEventObjects[0].Model.OnLeave?.Invoke(_instance._gameEventObjects[0]);
        _instance._gameEventObjects.RemoveAt(0);
        _instance._isRoundNotEnd = false;
    }

    /// <summary>
    /// 添加一个GameEvent
    /// </summary>
    /// <param name="ageInfo">添加的事件信息</param>
    public static void CreateGameEvent(AddGameEventInfo ageInfo)
    {
        var geObject = new GameEvent();

        _instance._gameEventObjects.Add(geObject);
        geObject.Model.OnCreate?.Invoke(geObject);
    }
}