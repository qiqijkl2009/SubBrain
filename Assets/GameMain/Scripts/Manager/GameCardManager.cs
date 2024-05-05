using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameCardManager : MonoBehaviour
{
    private static GameCardManager _instance;

    public static void Init()
    {
        _instance = ManagerRoot.RootTransform.GetComponentInChildren<GameCardManager>();
    }

    private readonly List<GameEventObject> _gameEvents = new();
    private readonly GameObject[] _gameActions = new GameObject[2];

    private GameEventObject _currentGameEvent = null;
    private GameObject _gameScene = null;

    /// <summary>
    /// 游戏事件队列，按添加顺序排序
    /// </summary>
    public static List<GameEventObject> GameEvents => _instance._gameEvents;

    /// <summary>
    /// 游戏行动列表，实际上只有两个位置，0为左行动，1为右行动
    /// </summary>
    public static GameObject[] GameActions => _instance._gameActions;

    /// <summary>
    /// 当前正在进行的游戏事件
    /// </summary>
    public static GameEventObject CurrentGameEvent
    {
        get => _instance._currentGameEvent;
        set => _instance._currentGameEvent = value;
    }

    /// <summary>
    /// 当前生效的游戏场景卡
    /// </summary>
    public static GameObject GameScene
    {
        get => _instance._gameScene;
        set => _instance._gameScene = value;
    }

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


    /// <summary>
    /// 添加一个GameAction
    /// </summary>
    /// <param name="action">游戏行动信息</param>
    /// <returns>游戏行动卡</returns>
    public static GameObject CreateGameAction(GameActionCreator action)
    {
        var actionObject = R.Card.ActionCard_GameObject();
        var actionState = actionObject.GetComponent<ActionState>();

        actionState.InitByGameActionCreator(action);

        if (GameActions[0] is null)
        {
            GameActions[0] = actionObject;
            actionObject.name = "LeftAction";
        }
        else
        {
            GameActions[1] = actionObject;
            actionObject.name = "RightAction";
        }

        return actionObject;
    }

    /// <summary>
    /// 改变目前的GameScene
    /// </summary>
    /// <param name="scene">游戏场景信息</param>
    /// <returns>新的游戏场景卡</returns>
    public static GameObject ChangeGameScene(GameSceneCreator scene)
    {
        if (GameScene)
        {
            var oldSceneState = GameScene.GetComponent<SceneState>();
            oldSceneState.Model.OnRemove?.Invoke(GameScene);

            foreach (var buff in oldSceneState.Model.Buffs)
            {
                ManagerVariant.AddBuff(buff.Opposite());
            }

            GameScene = null;
        }

        //TODO:换预制体
        var sceneObject = R.Card.ActionCard_GameObject();
        var sceneState = sceneObject.GetComponent<SceneState>();

        sceneState.InitByGameSceneCreator(scene);
        sceneState.Model.OnCreate?.Invoke(GameScene);

        foreach (var buff in sceneState.Model.Buffs)
        {
            ManagerVariant.AddBuff(buff);
        }

        GameScene = sceneObject;

        return sceneObject;
    }

    public static void SetCurrentEvent(GameEventObject gameEvent)
    {
        CurrentGameEvent = gameEvent;
    }
}