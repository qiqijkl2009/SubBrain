using System;
using DG.Tweening;
using TMPro;
using UnityEngine;

public class ActionState : MonoBehaviour
{
    /// <summary>
    /// 这是个什么行动
    /// </summary>
    public GameActionModel Model;

    /// <summary>
    /// 行动对应事件覆写，有需要触发强制事件的情况，就可以用覆写事件覆盖model自带的事件
    /// </summary>
    public GameActionToEvent GameActionOverride;

    public object[] GameActionOverrideArgs;

    private GameObject _viewContainer;


    private void Start()
    {
        SyncUnitComponents();
    }


    public void InitByGameActionCreator(GameActionCreator gameAction)
    {
        Model = gameAction.Model;

        SyncUnitComponents();
    }

    private void SyncUnitComponents()
    {
        if (!_viewContainer) _viewContainer = GetComponentInChildren<ViewContainer>().gameObject;
    }

    /// <summary>
    /// 使用这张行动卡
    /// </summary>
    public void TakeAction()
    {
        if (GameActionOverride is not null)
        {
            var gameEvent = GameActionOverride.Invoke(gameObject, 0, false, false);
            ManagerVariant.CreateGameEvent(gameEvent);
        }
        else
        {
            var gameEvent = Model.GameAction.Invoke(gameObject, 0, false, false);
            ManagerVariant.CreateGameEvent(gameEvent);
        }

        ManagerVariant.ModResource(Model.ModResource);
        
        transform.DOKill();
        ManagerVariant.RoundOver();
    }
}