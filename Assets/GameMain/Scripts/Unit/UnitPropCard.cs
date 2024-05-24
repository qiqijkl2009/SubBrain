using System;
using System.Linq;
using DG.Tweening;
using JKFrame;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;
using UnityEngine.UI;

/// <summary>
/// 单位卡片控件，所有拥有交互操作的卡片都应该添加这个来控制它
/// </summary>
public class UnitPropCard : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IBeginDragHandler, IEndDragHandler
{
    [SerializeField] private SpriteRenderer _background;
    [SerializeField] private SpriteRenderer _propImage;
    [SerializeField] private TMP_Text _propName;

    [FormerlySerializedAs("IsReturning")] public bool IsResetting = true;

    private float _depth;

    private bool _isFrozen;
    private bool _isDrag;

    private Vector3 _offset;

    private void Start()
    {
        JKFrame.EventSystem.AddEventListener(GameConstant.ScriptEvent.FREEZE_ANI, FreezeAnimation);
        JKFrame.EventSystem.AddEventListener(GameConstant.ScriptEvent.UNFREEZE_ANI, UnfreezeAnimation);

        SetView();
    }

    private void Update()
    {
        if (!_isDrag) return;

        var mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, _depth);
        if (Camera.main != null) transform.position = Camera.main.ScreenToWorldPoint(mousePosition);
    }

    private void OnDestroy()
    {
        JKFrame.EventSystem.RemoveEventListener(GameConstant.ScriptEvent.FREEZE_ANI, FreezeAnimation);
        JKFrame.EventSystem.RemoveEventListener(GameConstant.ScriptEvent.UNFREEZE_ANI, UnfreezeAnimation);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (_isFrozen || IsResetting) return;

        _background.sprite = R.Texture.Prop_Background_Selected_Prop_Background_Selected;
        transform.DOKill();
        transform.localScale = new Vector3(1.1f, 1.1f, 1f);
        transform.DOLocalMove(new Vector3(transform.localPosition.x, 0.5f), 0.5f);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (_isFrozen || IsResetting) return;

        ReturnToOrigin();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        if (_isFrozen || IsResetting) return;

        _isDrag = true;

        transform.DOKill();
        if (Camera.main != null) _depth = Camera.main.WorldToScreenPoint(transform.position).z;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        var temp = new RaycastHit2D[3];
        int infoNums = 0;
        
        if (_isDrag)
        {
            infoNums = Physics2D.RaycastNonAlloc(Camera.main!.ScreenToWorldPoint(eventData.position), Vector2.zero, temp);
            
            _isDrag = false;
            IsResetting = true;
            ReturnToOrigin();
        }
        
        if (_isFrozen) return;
        if (infoNums <= 0) return;
        if (temp.All(info => info.collider == null || info.collider.GetComponent<EventContainer>() == null)) return;

        GetComponent<PropState>().ConsumeProp();
    }


    private void ReturnToOrigin()
    {
        _background.sprite = R.Texture.Prop_Background_Unselected_Prop_Background_Unselected;

        transform.DOKill();
        transform.localScale = Vector3.one;

        FindObjectOfType<PropContainer>().SortPropCards();
    }

    /// <summary>
    /// 设置卡面UI
    /// </summary>
    private void SetView()
    {
        var uiInfo = GetComponent<PropState>().Model.UIInfo;

        _propImage.sprite = ResSystem.LoadAsset<Sprite>(uiInfo.TextureId);
        _propName.text = uiInfo.Title;
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