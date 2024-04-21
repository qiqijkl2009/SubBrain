using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
using DG.Tweening;
using System;

public class ShowRecords : MonoBehaviour
{
    private TextMeshProUGUI RoundCount;
    private TextMeshProUGUI RecordText;


    private void Awake()
    {
        Records.refresh += RefreshText;
    }


    // Start is called before the first frame update
    void Start()
    {
        RoundCount = transform.GetChild(0).GetComponent<TextMeshProUGUI>();
        RecordText = transform.GetChild(1).GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {


    }

    private void RefreshText()
    {
        RoundCount.text = "Round Count: " + Records.RoundCount;
        RecordText.text = Records.RecordContents;
    }
}
