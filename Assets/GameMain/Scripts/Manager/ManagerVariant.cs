﻿using System.Collections.Generic;
using UnityEngine;

public class ManagerVariant
{
    /// <summary>
    /// 获得事件列表
    /// </summary>
    public static List<GameEventObject> GameEvents()
    {
        return GameEventManager.GameEvents;
    }

    /// <summary>
    /// 获得当前进行的事件
    /// </summary>
    public static GameEventObject CurrentGameEvent()
    {
        return GameEventManager.CurrentGameEvent;
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
        GameEventManager.CreateGameEvent(model, waitRounds, isRepeat, isOnly);
    }

    /// <summary>
    /// 添加一个GameEvent
    /// </summary>
    /// <param name="gameEvent">游戏事件实例</param>
    public static void CreateGameEvent(GameEventObject gameEvent)
    {
        GameEventManager.CreateGameEvent(gameEvent);
    }


    #region Buff相关

    /// <summary>
    /// 获得当前的Buff列表
    /// </summary>
    public static List<BuffObject> Buffs()
    {
        return BuffManager.Buffs;
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

    /// <summary>
    /// 回合结束流程
    /// </summary>
    /// <param name="roundCount">经过的回合数</param>
    public static void RoundOver(int roundCount = 1)
    {
        RoundManager.RoundOver();
    }
}