using System;
using DG.Tweening;
using TMPro;
using UnityEngine;

public class EventPanel : MonoBehaviour
{
    [SerializeField] private Transform TestContainer;

    private GameObject _currentEvent;
    private GameObject _leftAction;
    private GameObject _rightAction;

    private void Update()
    {
        var gameActions = ManagerVariant.GameActions();
        if (!_leftAction && gameActions[0])
        {
            _leftAction = gameActions[0];
            _leftAction.transform.SetParent(TestContainer);
        }

        if (!_rightAction && gameActions[1])
        {
            _rightAction = gameActions[1];
            _rightAction.transform.SetParent(TestContainer);
        }
    }
}