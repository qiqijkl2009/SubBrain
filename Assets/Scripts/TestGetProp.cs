using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
using DG.Tweening;

public class TestGetProp : MonoBehaviour
{
    public Button TestBtn;
    public Transform PropCardsParent;
    public List<Transform> propGroup;

    // Start is called before the first frame update
    void Start()
    {
        PropCardsParent = GameObject.Find("PropCards").transform;
        for (int i = 0; i < PropCardsParent.childCount; i++)
        {
            propGroup.Add(PropCardsParent.GetChild(i));
        }

        TestBtn = GetComponent<Button>();
        TestBtn.onClick.AddListener(delegate()
        {
            PropManager.Instance.GetProp(propGroup);
        }) ;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
