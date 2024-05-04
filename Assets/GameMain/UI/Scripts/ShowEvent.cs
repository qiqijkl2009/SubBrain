using System;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using JKFrame;

public class ShowEvent : MonoBehaviour
{
    [SerializeField] private TMP_Text EventTitle;
    [SerializeField] private TMP_Text EventContent;
    [SerializeField] private Image EventImage;

    private Sprite _eventImageSprite;

    private void Start()
    {
        Records.Refresh += RefreshEvent;
    }

    public void RefreshEvent()
    {
        var currentGameEvent = ManagerVariant.CurrentGameEvent();
        var uiInfo = currentGameEvent.Model.UIInfo;
        
        EventTitle.text = uiInfo.Title;
        EventContent.text = uiInfo.Content;
        
        ResSystem.UnloadAsset(_eventImageSprite);
        _eventImageSprite = ResSystem.LoadAsset<Sprite>(uiInfo.TextureId);
        EventImage.sprite = _eventImageSprite;
    }

    private void OnDestroy()
    {
        ResSystem.UnloadAsset(_eventImageSprite);
    }
}