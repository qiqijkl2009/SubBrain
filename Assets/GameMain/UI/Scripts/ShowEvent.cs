using System;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using JKFrame;
using UnityEngine.EventSystems;
using DG.Tweening;

public class ShowEvent : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private TMP_Text EventTitle;
    [SerializeField] private TMP_Text EventContent;
    [SerializeField] private Image EventImage;
    [SerializeField] private int ClickCount = 0;

    private Sprite _eventImageSprite;

    private void Awake()
    {
        JKFrame.EventSystem.AddEventListener("NewGameEventCreated", RefreshEvent);
    }

    private void Start()
    {

    }

    public void RefreshEvent()
    {
        transform.DOScale(1f, 2f).OnComplete(() => 
        {
            var currentGameEvent = ManagerVariant.CurrentGameEvent();
            var uiInfo = currentGameEvent.Model.UIInfo;

            EventTitle.text = uiInfo.Title;
            EventContent.text = uiInfo.Content;
            GoToStart(); //回到文字第一页

            ResSystem.UnloadAsset(_eventImageSprite);
            _eventImageSprite = ResSystem.LoadAsset<Sprite>(uiInfo.TextureId);
            EventImage.sprite = _eventImageSprite;
        });
    }

    private void OnDestroy()
    {
        ResSystem.UnloadAsset(_eventImageSprite);
        JKFrame.EventSystem.RemoveEventListener("NewGameEventCreated", RefreshEvent);
    }

    public void OnPointerClick(PointerEventData eventData) //点击显示下一页文字
    {
        if (ClickCount < EventContent.textInfo.pageCount - 1)
        {
            EventContent.pageToDisplay += 1;
            ClickCount++;
        }
        else
        {
            GoToStart();
        }
    }

    void GoToStart() //回到文字第一页
    {
        ClickCount = 0;
        EventContent.pageToDisplay = 1;
    }
}