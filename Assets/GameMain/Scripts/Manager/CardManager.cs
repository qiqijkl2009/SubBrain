using System;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    private static CardManager _instance;

    public static void Init()
    {
        _instance = ManagerRoot.RootTransform.GetComponentInChildren<CardManager>();
    }

    private List<CardState> _propCards;
    private List<CardRecord> _consumedCards;
    private CardState _sceneCard;

    private void FixedUpdate()
    {
    }

    public static void ChangeSceneCard(GameObject card)
    {
        
    }

    public static void ConfirmCardSelection(GameObject card)
    {
        var state = card.GetComponent<CardState>();
    }
}