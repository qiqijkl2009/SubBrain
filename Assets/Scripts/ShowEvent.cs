using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
using DG.Tweening;
using System;

public class ShowEvent : MonoBehaviour
{
    private TextMeshProUGUI EventText;

    private void Awake()
    {
        Records.refresh += RefreshEvent;
    }

    // Start is called before the first frame update
    void Start()
    {
        EventText = transform.GetChild(0).GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void RefreshEvent()
    {
        EventText.text = "Event " + Records.EventCount;
    }
}
