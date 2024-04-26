using UnityEngine;
using TMPro;

public class ShowEvent : MonoBehaviour
{
    [SerializeField] private TMP_Text EventText;

    private void Start()
    {
        Records.Refresh += RefreshEvent;
    }


    private void RefreshEvent()
    {
        EventText.text = "事件 " + Records.EventCount;
    }
}