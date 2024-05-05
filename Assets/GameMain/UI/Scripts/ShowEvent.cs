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
        //����Ľӿ���Ҫ����
        Records.Refresh += RefreshEvent;

        //����Ч����
        EventContent.text = "��������������˫��,ͷʹ���ѡ���������,�����Լ�����һ�ų¾ɵĲ����ϡ���������һ���ƾɵıʼǱ���һ֧�ֱʡ��ҷ����ʼǱ�,�������������һϵ�е���ıʼ�,���ҵ����ֱ�д����ˡ�������ɯ��";
    }

    public void RefreshEvent()
    {
        var currentGameEvent = ManagerVariant.CurrentGameEvent();
        var uiInfo = currentGameEvent.Model.UIInfo;

        EventTitle.text = uiInfo.Title;
        EventContent.text = uiInfo.Content;
        GoToStart(); //�ص����ֵ�һҳ

        ResSystem.UnloadAsset(_eventImageSprite);
        _eventImageSprite = ResSystem.LoadAsset<Sprite>(uiInfo.TextureId);
        EventImage.sprite = _eventImageSprite;
    }

    private void OnDestroy()
    {
        ResSystem.UnloadAsset(_eventImageSprite);
    }

    public void OnPointerClick(PointerEventData eventData) //�����ʾ��һҳ����
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

    void GoToStart() //�ص����ֵ�һҳ
    {
        ClickCount = 0;
        EventContent.pageToDisplay = 1;
    }
}