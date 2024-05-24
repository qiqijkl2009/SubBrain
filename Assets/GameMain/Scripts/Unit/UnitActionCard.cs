using System;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

/// <summary>
/// 行动卡控件，所有拥有交互操作的行动卡都应该添加这个来控制它
/// </summary>
public class UnitActionCard : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    private const float INIT_ANI_DURATION = 1.2f;
    private const float ACTION_MOVE_ANI_DURATION = 1.2f;

    [SerializeField] private SpriteRenderer _background;
    [SerializeField] private TMP_Text _actionTitle;

    private bool _isFrozen;
    private Sprite _eventPanelSprite;

    private void Start()
    {
        JKFrame.EventSystem.AddEventListener(GameConstant.ScriptEvent.FREEZE_ANI, FreezeAnimation);
        JKFrame.EventSystem.AddEventListener(GameConstant.ScriptEvent.UNFREEZE_ANI, UnfreezeAnimation);
        _eventPanelSprite = R.Texture.EventPanel_EventPanel;

        SetView();
    }

    private void OnDestroy()
    {
        JKFrame.EventSystem.RemoveEventListener(GameConstant.ScriptEvent.FREEZE_ANI, FreezeAnimation);
        JKFrame.EventSystem.RemoveEventListener(GameConstant.ScriptEvent.UNFREEZE_ANI, UnfreezeAnimation);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (_isFrozen) return;

        JKFrame.EventSystem.EventTrigger(GameConstant.ScriptEvent.FREEZE_ANI);

        var gameActions = ManagerVariant.GameActions();
        var otherAction = gameObject == gameActions[0]
            ? gameActions[1]
            : gameActions[0];

        if (otherAction) otherAction.GetComponent<UnitActionCard>().ReturnToOrigin();

        var eventPanelPosition = FindObjectOfType<EventPanel>().transform.position;
        var target = new Vector3(eventPanelPosition.x, eventPanelPosition.y, -5);

        transform.DOKill();
        transform.DOMove(target, ACTION_MOVE_ANI_DURATION);
        transform.DORotate(new Vector3(0, 90, 0), 0.5f).OnComplete(() =>
        {
            transform.DORotate(Vector3.zero, 1f);
            _background.sprite = _eventPanelSprite;

            DOTween.To(() => _background.size, x => _background.size = x, new Vector2(_eventPanelSprite.bounds.size.x, _eventPanelSprite.bounds.size.y), 1f)
                .OnComplete(() =>
                {
                    GetComponent<ActionState>().TakeAction();
                    JKFrame.EventSystem.EventTrigger(GameConstant.ScriptEvent.UNFREEZE_ANI);
                });
        });
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (_isFrozen) return;

        var gameActions = ManagerVariant.GameActions();
        var target = gameObject == gameActions[0]
            ? new Vector3(-0.2f, 0)
            : new Vector3(0.2f, 0);

        transform.DOKill();
        transform.DOLocalMove(target, 0.5f);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (_isFrozen) return;

        transform.DOKill();
        transform.DOLocalMove(Vector3.zero, 0.5f);
    }

    /// <summary>
    /// 让卡牌回归轴心点
    /// </summary>
    public void ReturnToPivot()
    {
        _isFrozen = true;

        JKFrame.EventSystem.EventTrigger(GameConstant.ScriptEvent.FREEZE_ANI);

        transform.DOKill();
        transform.DOLocalMove(Vector3.zero, INIT_ANI_DURATION).OnComplete(() => JKFrame.EventSystem.EventTrigger(GameConstant.ScriptEvent.UNFREEZE_ANI));
        transform.DOLocalRotate(Vector3.zero, INIT_ANI_DURATION);
    }

    /// <summary>
    /// 让卡牌回归原点
    /// </summary>
    private void ReturnToOrigin()
    {
        _isFrozen = true;

        var eventPanelPosition = FindObjectOfType<EventPanel>().transform.position;
        var target = new Vector3(eventPanelPosition.x, eventPanelPosition.y, 1);

        transform.DOKill();
        transform.DOMove(target, ACTION_MOVE_ANI_DURATION);
        transform.DORotate(Vector3.zero, ACTION_MOVE_ANI_DURATION);
    }

    /// <summary>
    /// 设置卡面UI
    /// </summary>
    private void SetView()
    {
        var uiInfo = GetComponent<ActionState>().Model.UIInfo;

        _actionTitle.text = uiInfo.Title;
    }

    /// <summary>
    /// 设置动画锁定
    /// </summary>
    private void FreezeAnimation()
    {
        _isFrozen = true;
    }

    /// <summary>
    /// 解除动画锁定
    /// </summary>
    private void UnfreezeAnimation()
    {
        _isFrozen = false;
    }
}