using System.Collections.Generic;
using UnityEngine;

public class ManagerVariant
{
    #region 游戏进程相关

    /// <summary>
    /// 开始游戏并初始化第一个回合
    /// </summary>
    public void StartGame()
    {
        GameManager.StartGame();
    }
    
    /// <summary>
    /// 结束游戏并进行结算
    /// </summary>
    public void GameOver()
    {
        GameManager.GameOver();
    }

    #endregion
    
    #region 游戏卡牌相关

    /// <summary>
    /// 获得事件列表
    /// </summary>
    public static List<GameEventObject> GameEvents()
    {
        return GameCardManager.GameEvents;
    }

    /// <summary>
    /// 获得当前进行的事件
    /// </summary>
    public static GameEventObject CurrentGameEvent()
    {
        return GameCardManager.CurrentGameEvent;
    }

    /// <summary>
    /// 获得当前进行的事件
    /// </summary>
    public static GameObject[] GameActions()
    {
        return GameCardManager.GameActions;
    }

    /// <summary>
    /// 获得当前生效的游戏场景卡
    /// </summary>
    public static GameObject GameScene()
    {
        return GameCardManager.GameScene;
    }

    /// <summary>
    /// 设置当前的GameEvent
    /// </summary>
    /// <param name="gameEvent">GameEvent实例</param>
    public static void SetCurrentGameEvent(GameEventObject gameEvent)
    {
        GameCardManager.SetCurrentGameEvent(gameEvent);
    }

    /// <summary>
    /// 事件进入流程
    /// </summary>
    public static void EnterGameEvent()
    {
        GameCardManager.EnterGameEvent();
    }

    /// <summary>
    /// 离开当前进行的GameEvent
    /// </summary>
    public static void LeaveGameEvent()
    {
        GameCardManager.LeaveGameEvent();
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
        GameCardManager.CreateGameEvent(model, waitRounds, isRepeat, isOnly);
    }

    /// <summary>
    /// 添加一个GameEvent至列表
    /// </summary>
    /// <param name="gameEvent">GameEvent实例</param>
    public static void CreateGameEvent(GameEventObject gameEvent)
    {
        GameCardManager.CreateGameEvent(gameEvent);
    }

    /// <summary>
    /// 添加一个GameAction
    /// </summary>
    /// <param name="gameAction">GameAction信息</param>
    /// <returns>GameAction卡</returns>
    public static GameObject CreateGameAction(GameActionCreator gameAction)
    {
        return GameCardManager.CreateGameAction(gameAction);
    }

    /// <summary>
    /// 改变目前的GameScene
    /// </summary>
    /// <param name="gameScene">GameScene信息</param>
    /// <returns>新的GameScene卡</returns>
    public static GameObject ChangeGameScene(GameSceneCreator gameScene)
    {
        return GameCardManager.ChangeGameScene(gameScene);
    }
    
    #endregion

    #region Buff相关

    /// <summary>
    /// 获得当前的Buff列表
    /// </summary>
    public static List<BuffObject> Buffs()
    {
        return BuffManager.Buffs;
    }

    /// <summary>
    /// Buff结算更新流程
    /// </summary>
    /// <param name="roundCount">经过的回合数</param>
    public static void BuffUpdate(int roundCount)
    {
        BuffManager.BuffUpdate(roundCount);
    }

    /// <summary>
    /// 为角色添加buff，删除buff也是走这个的，只不过删除的流程不在这里处理
    /// </summary>
    /// <param name="buff">要改变的Buff</param>
    public static void AddBuff(AddBuffInfo buff)
    {
        BuffManager.AddBuff(buff);
    }

    ///<summary>
    ///获取角色身上对应的BuffObject
    ///<param name="id">Buff的Model的Id</param>
    ///<param name="source">如果source不为空，那么就代表只有BuffObject.Source在source里面的才符合条件</param>
    ///<return>符合条件的BuffObject数组</return>
    ///</summary>
    public static List<BuffObject> GetBuffById(string id, List<GameObject> source = null)
    {
        return BuffManager.GetBuffById(id, source);
    }

    #endregion

    #region 道具相关

    /// <summary>
    /// 获取当前持有的道具卡
    /// </summary>
    public static List<GameObject> PropCards()
    {
        return PropManager.PropCards;
    }

    /// <summary>
    /// 创建一张道具卡
    /// </summary>
    /// <param name="prop">要创建的道具卡信息</param>
    /// <returns>创建出的道具卡实例</returns>
    public static GameObject CreateProp(PropCreator prop)
    {
        return PropManager.CreateProp(prop);
    }

    /// <summary>
    /// 移除一张道具卡
    /// </summary>
    /// <param name="prop">被移除的道具卡</param>
    /// <param name="isDestroy">是否为强制移除（无视使用次数）</param>
    public static void RemoveProp(GameObject prop, bool isDestroy = false)
    {
        PropManager.RemoveProp(prop, isDestroy);
    }

    #endregion

    #region 回合相关

    /// <summary>
    /// 触发回合开始流程
    /// </summary>
    public static void RoundStart()
    {
        RoundManager.RoundStart();
    }

    /// <summary>
    /// 触发回合结束流程
    /// </summary>
    /// <param name="roundCount">经过的回合数</param>
    public static void RoundOver(int roundCount = 1)
    {
        RoundManager.RoundOver();
    }

    #endregion

    #region 属性相关

    /// <summary>
    /// 当前角色的资源类属性
    /// </summary>
    public static CharacterResource Resource()
    {
        return StatsManager.Resource;
    }

    ///<summary>
    ///改变角色的资源类属性，
    ///<param name="value">要改变的量，负数为减少</param>
    ///</summary>
    public static void ModResource(CharacterResource value)
    {
        StatsManager.ModResource(value);
    }

    #endregion
}