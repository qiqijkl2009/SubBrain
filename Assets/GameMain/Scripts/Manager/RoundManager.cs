using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class RoundManager : MonoBehaviour
{
    private static RoundManager _instance;

    public static void Init()
    {
        _instance = ManagerRoot.RootTransform.GetComponentInChildren<RoundManager>();
    }
    

    /// <summary>
    /// 回合开始流程
    /// </summary>
    public static void RoundStart()
    {
        //进行事件进入流程
        ManagerVariant.EnterGameEvent();
    }

    /// <summary>
    /// 回合结束流程
    /// </summary>
    /// <param name="roundCount">经过的回合数</param>
    public static void RoundOver(int roundCount = 1)
    {
        //进行事件退出流程
        ManagerVariant.LeaveGameEvent();

        //进行buff结算流程
        ManagerVariant.BuffUpdate(roundCount);

        //所有回合结算完成，进行回合开始流程
        RoundStart();
    }
}