using DG.Tweening;
using JKFrame;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using EventSystem = JKFrame.EventSystem;

public class EventContainer : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameOverMask _gameOverMask;
    [SerializeField] private SpriteRenderer _eventImage;
    [SerializeField] private TMP_Text _eventContent;
    [SerializeField] private Transform _pageSign;

    private void Start()
    {
        EventSystem.AddEventListener(GameConstant.ScriptEvent.ENTER_NEW_EVENT, RefreshEvent);
        EventSystem.AddEventListener(GameConstant.ScriptEvent.END_GAME, OnEndGame);
        _pageSign.DOLocalMove(_pageSign.localPosition + new Vector3(0, 0.05f, 0), 1f)
            .SetEase(Ease.Linear)
            .SetLoops(-1, LoopType.Yoyo);
    }

    private void OnDestroy()
    {
        EventSystem.RemoveEventListener(GameConstant.ScriptEvent.ENTER_NEW_EVENT, RefreshEvent);
        EventSystem.RemoveEventListener(GameConstant.ScriptEvent.END_GAME, OnEndGame);
    }

    private void Update()
    {
        _pageSign.gameObject.SetActive(_eventContent.textInfo.pageCount > 1);
    }

    private void RefreshEvent()
    {
        _eventImage.color = new Color(1, 1, 1, 0);
        _eventContent.color = Color.clear;

        var currentGameEvent = ManagerVariant.CurrentGameEvent();
        var uiInfo = currentGameEvent.Model.UIInfo;

        _eventImage.sprite = ResSystem.LoadAsset<Sprite>(uiInfo.TextureId);
        _eventContent.text = uiInfo.Content;
        _eventContent.pageToDisplay = 1;

        _eventImage.DOColor(Color.white, 1f);
        _eventContent.DOColor(Color.black, 1f);
    }

    private void OnEndGame()
    {
        _gameOverMask.ShowMask();
        _eventImage.transform.DOKill();
        _eventImage.transform.DOMoveZ(_gameOverMask.transform.position.z - 1, 0f);
        _eventImage.transform.DOScale(1.2f, 3f);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (_eventContent.pageToDisplay < _eventContent.textInfo.pageCount)
        {
            _eventContent.pageToDisplay++;
        }
        else
        {
            _eventContent.pageToDisplay = 1;
        }
    }
}