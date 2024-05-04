using System;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using JKFrame;
using UnityEngine.EventSystems;

public class ShowEvent : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private TMP_Text EventTitle;
    [SerializeField] private TMP_Text EventContent;
    [SerializeField] private Image EventImage;
    [SerializeField] private int ClickCount = 0;

    private Sprite _eventImageSprite;

    private void Start()
    {
        //这里的接口需要更新
        Records.Refresh += RefreshEvent;

        //测试效果用
        EventContent.text = "我慢慢地睁开了双眼,头痛欲裂。环顾四周,发现自己躺在一张陈旧的病床上。手碰到了一本破旧的笔记本和一支钢笔。我翻开笔记本,发现上面记载着一系列调查的笔记,而我的名字被写在最顶端——艾丽莎。";
    }

    public void RefreshEvent()
    {
        var currentGameEvent = ManagerVariant.CurrentGameEvent();
        var uiInfo = currentGameEvent.Model.UIInfo;

        EventTitle.text = uiInfo.Title;
        EventContent.text = uiInfo.Content;
        GoToStart(); //回到文字第一页

        ResSystem.UnloadAsset(_eventImageSprite);
        _eventImageSprite = ResSystem.LoadAsset<Sprite>(uiInfo.TextureId);
        EventImage.sprite = _eventImageSprite;
    }

    private void OnDestroy()
    {
        ResSystem.UnloadAsset(_eventImageSprite);
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