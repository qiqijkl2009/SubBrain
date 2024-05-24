using System;
using System.Collections.Generic;
using System.Linq;
using DG.Tweening;
using JKFrame;
using UnityEngine;

public class PropContainer : MonoBehaviour
{
    private const float CARD_SPACING = 2f;
    private const float MOVE_ANI_DURATION = 1.5f;

    private void Start()
    {
        EventSystem.AddEventListener(GameConstant.ScriptEvent.CREATE_NEW_PROP, SortPropCards);
        SortPropCards();
    }

    private void OnDestroy()
    {
        EventSystem.RemoveEventListener(GameConstant.ScriptEvent.CREATE_NEW_PROP, SortPropCards);
    }

    public void SortPropCards()
    {
        var propCards = ManagerVariant.PropCards();
        foreach (var prop in propCards)
        {
            prop.transform.SetParent(transform, true);
        }

        int mid = propCards.Count / 2;
        int res = propCards.Count % 2;

        if (res == 0)
        {
            for (int i = 1; i <= mid; i++)
            {
                MovePropCard(propCards[mid - i].transform, new Vector3(-CARD_SPACING * (i - 0.5f), 0, 0));
                MovePropCard(propCards[mid + i - 1].transform, new Vector3(CARD_SPACING * (i - 0.5f), 0, 0));
            }
        }
        else
        {
            MovePropCard(propCards[mid].transform, Vector3.zero);
            for (int i = 1; i <= mid; i++)
            {
                MovePropCard(propCards[mid - i].transform, new Vector3(-CARD_SPACING * i, 0, 0));
                MovePropCard(propCards[mid + i].transform, new Vector3(CARD_SPACING * i, 0, 0));
            }
        }
    }

    private static void MovePropCard(Transform card, Vector3 position)
    {
        card.DOLocalMove(position, MOVE_ANI_DURATION).OnComplete(() => card.GetComponent<UnitPropCard>().IsResetting = false);
    }
}