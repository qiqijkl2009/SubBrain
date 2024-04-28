using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
using DG.Tweening;

public class Prop : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private Vector3 OriginalPos;
    private Vector3 Offset;
    private bool CanUse;

    // Start is called before the first frame update
    void Start()
    {
        OriginalPos = transform.position;
        CanUse = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Drag();
        }
        if (Input.GetMouseButtonUp(0))
        {
            if (!CanUse)
            {
                transform.DOMove(OriginalPos, 2f);
            }

        }
    }

    private void FixedUpdate()
    {

    }

    private void Drag()
    {
        transform.position = Input.mousePosition;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        transform.DOScale(1.1f, 1f);
        transform.DORotate(new Vector3(0, 0, UnityEngine.Random.Range(-2f, 2f)), 1f); 
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        transform.DOScale(1f, 1f);
        transform.DORotate(new Vector3(0, 0, 0), 1f);
    }
}
