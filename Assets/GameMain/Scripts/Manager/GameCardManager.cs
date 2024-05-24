using System.Collections.Generic;
using System.Linq;
using DG.Tweening;
using JKFrame;
using UnityEngine;

public class GameCardManager : MonoBehaviour
{
    private static GameCardManager _instance;

    public static void Init()
    {
        _instance = ManagerRoot.RootTransform.GetComponentInChildren<GameCardManager>();
    }

    private readonly List<GameEventObject> _gameEvents = new();
    private readonly GameObject[] _gameActions = { null, null };

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
        private set => _instance._currentGameEvent = value;
    }

    /// <summary>
    /// 当前生效的游戏场景卡
    /// </summary>
    public static GameObject GameScene
    {
        get => _instance._gameScene;
        private set => _instance._gameScene = value;
    }

    /// <summary>
    /// 事件进入流程
    /// </summary>
    public static void EnterGameEvent()
    {
        var toEnter = GameEvents.Where(e => e.WaitRounds == 0).ToList();

        if (toEnter.Count > 0)
        {
            CurrentGameEvent = toEnter[0];
        }
        else
        {
            //让玩家自由行动
            return;
        }

        foreach (var eventObject in GameEvents.Where(e => e.WaitRounds > 0))
        {
            eventObject.WaitRounds--;
        }

        EnterCurrentEvent();
    }

    private static void EnterCurrentEvent()
    {
        if (CurrentGameEvent.Model.AudioId != null)
        {
            AudioSystem.PlayOneShot(ResSystem.LoadAsset<AudioClip>(CurrentGameEvent.Model.AudioId), null, true);
        }

        CurrentGameEvent.Model.OnEnter?.Invoke(CurrentGameEvent);
        foreach (var action in CurrentGameEvent.Model.GameActions)
        {
            if (!string.IsNullOrEmpty(action.Id) && ManagerVariant.Resource().Enough(action.Requirement))
            {
                CreateGameAction(new GameActionCreator(action));
            }
        }
        //传递给UI，事件or接口调用，把这些行动传过去
        EventSystem.EventTrigger(GameConstant.ScriptEvent.ENTER_NEW_EVENT);
    }

    /// <summary>
    /// 事件退出流程
    /// </summary>
    public static void LeaveGameEvent()
    {
        CurrentGameEvent.Model.OnLeave?.Invoke(CurrentGameEvent);
        GameEvents.Remove(CurrentGameEvent);

        if (CurrentGameEvent.IsRepeat)
        {
            CreateGameEvent(CurrentGameEvent.Model);
        }

        if (GameActions[0])
        {
            GameActions[0].transform.DOKill();
            DestroyImmediate(GameActions[0]);
        }

        if (GameActions[1])
        {
            GameActions[1].transform.DOKill();
            DestroyImmediate(GameActions[1]);
        }

        CurrentGameEvent = null;
        GameActions[0] = null;
        GameActions[1] = null;
    }

    /// <summary>
    /// 设置当前的GameEvent
    /// </summary>
    /// <param name="gameEvent">GameEvent实例</param>
    public static void SetCurrentGameEvent(GameEventObject gameEvent)
    {
        LeaveGameEvent();
        CurrentGameEvent = gameEvent;
        EnterCurrentEvent();
    }

    /// <summary>
    /// 添加一个GameEvent至列表
    /// </summary>
    /// <param name="model">GameEvent模板</param>
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
    /// <param name="gameEvent">GameEvent实例</param>
    public static void CreateGameEvent(GameEventObject gameEvent)
    {
        if (gameEvent.IsOnly && GameEvents.Any(e => e.Model.Id == gameEvent.Model.Id)) return;

        GameEvents.Add(gameEvent);
        gameEvent.Model.OnCreate?.Invoke(gameEvent);
    }


    /// <summary>
    /// 添加一个GameAction
    /// </summary>
    /// <param name="gameAction">GameAction信息</param>
    /// <returns>GameAction卡</returns>
    public static GameObject CreateGameAction(GameActionCreator gameAction)
    {
        var actionObject = R.Card.ActionCard_GameObject();
        var actionState = actionObject.GetComponent<ActionState>();

        actionState.InitByGameActionCreator(gameAction);

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
    /// <param name="gameScene">GameScene信息</param>
    /// <returns>新的GameScene卡</returns>
    public static GameObject ChangeGameScene(GameSceneCreator gameScene)
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

        sceneState.InitByGameSceneCreator(gameScene);
        sceneState.Model.OnCreate?.Invoke(GameScene);

        foreach (var buff in sceneState.Model.Buffs)
        {
            ManagerVariant.AddBuff(buff);
        }

        GameScene = sceneObject;

        return sceneObject;
    }
}