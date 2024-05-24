using UnityEngine;
using TMPro;
using UnityEngine.UI;
using JKFrame;
using UnityEngine.EventSystems;
using DG.Tweening;
using EventSystem = JKFrame.EventSystem;

public class ShowEvent : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private Image EventImage;
    [SerializeField] private TMP_Text EventContent;
    [SerializeField] private int ClickCount = 0;

    private Sprite _eventImageSprite;

    private void Start()
    {
        EventSystem.AddEventListener(GameConstant.ScriptEvent.ENTER_NEW_EVENT, RefreshEvent);
    }

    private void OnDestroy()
    {
        if (_eventImageSprite) ResSystem.UnloadAsset(_eventImageSprite);
        EventSystem.RemoveEventListener(GameConstant.ScriptEvent.ENTER_NEW_EVENT, RefreshEvent);
    }

    private void RefreshEvent()
    {
        transform.DOScale(1f, 0f).OnComplete(() =>
        {
            var currentGameEvent = ManagerVariant.CurrentGameEvent();
            var uiInfo = currentGameEvent.Model.UIInfo;

            EventContent.text = uiInfo.Content;
            GoToStart(); //回到文字第一页

            if (_eventImageSprite) ResSystem.UnloadAsset(_eventImageSprite);
            _eventImageSprite = ResSystem.LoadAsset<Sprite>(uiInfo.TextureId);
            EventImage.sprite = _eventImageSprite;
        });
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

    private void GoToStart() //回到文字第一页
    {
        ClickCount = 0;
        EventContent.pageToDisplay = 1;
    }
}