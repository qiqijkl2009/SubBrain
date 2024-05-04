using System;
using DG.Tweening;
using TMPro;
using UnityEngine;

public class ActionState : MonoBehaviour
{
    public GameActionModel Model;
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

    public void TakeAction()
    {
        if (GameActionOverride is not null)
        {
            var gameEvent = GameActionOverride.Invoke(gameObject);
            ManagerVariant.CreateGameEvent(gameEvent);
        }
        else
        {
            var gameEvent = Model.GameAction.Invoke(gameObject);
            ManagerVariant.CreateGameEvent(gameEvent);
        }

        ManagerVariant.RoundOver();
    }
}