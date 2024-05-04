using System;
using DG.Tweening;
using TMPro;
using UnityEngine;

public class SceneState : MonoBehaviour
{
    public GameSceneModel Model;

    private GameObject _viewContainer;


    private void Start()
    {
        SyncUnitComponents();
    }


    public void InitByGameSceneCreator(GameSceneCreator gameScene)
    {
        Model = gameScene.Model;

        SyncUnitComponents();
    }

    private void SyncUnitComponents()
    {
        if (!_viewContainer) _viewContainer = GetComponentInChildren<ViewContainer>().gameObject;
    }

    public void SelectScene()
    {
        Model.OnSelect?.Invoke(gameObject);
    }
}