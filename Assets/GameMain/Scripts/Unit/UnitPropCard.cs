using JKFrame;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

/// <summary>
/// 单位卡片控件，所有拥有交互操作的卡片都应该添加这个来控制它
/// </summary>
public class UnitPropCard : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    [SerializeField] private Image PropIcon;
    [SerializeField] private TMP_Text PropName;
    [SerializeField] private Sprite MouseIn;
    [SerializeField] private Sprite MouseOut;
    private Transform[] ActionCards;
    private Vector3 _originalPos;
    private Vector3 _offset;
    private bool _canUse;

    private void Start()
    {
        _originalPos = transform.position;
        _canUse = false;
        var propInfo = transform.GetComponent<PropState>();
        PropIcon.sprite = ResSystem.LoadAsset<Sprite>(propInfo.Model.UIInfo.TextureId);
        PropName.text = propInfo.Model.Name;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        transform.GetComponentInChildren<Image>().sprite = MouseIn;
        transform.localScale = new Vector3(1.1f, 1.1f, 1.1f);
        //transform.DORotate(new Vector3(0, 0, Random.Range(-2f, 2f)), 1f);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (! transform.GetComponentInChildren<CanvasGroup>().blocksRaycasts)
        {
            return;
        }
        transform.GetComponentInChildren<Image>().sprite = MouseOut;
        transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        //transform.DORotate(new Vector3(0, 0, 0), 1f);
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        if (GameManager.IsActionCardMoving)
        {
            return;
        }
        transform.GetComponentInChildren<CanvasGroup>().blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (GameManager.IsActionCardMoving)
        {
            return;
        }
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        GameObject EndObject = eventData.pointerCurrentRaycast.gameObject;
        Debug.Log(EndObject.transform.name);
        transform.GetComponentInChildren<Image>().sprite = MouseOut;

        //判断道具是否放在了事件卡上使用
        if (EndObject.transform.parent.tag == "EventCardArea")
        {
            GetComponent<PropState>().ConsumeProp();
            LayoutRebuilder.ForceRebuildLayoutImmediate(transform.parent.GetComponent<RectTransform>());
        }
        else
        {
            LayoutRebuilder.ForceRebuildLayoutImmediate(transform.parent.GetComponent<RectTransform>());
        }

        transform.GetComponentInChildren<CanvasGroup>().blocksRaycasts = true;
    }

    private void OnDestroy()
    {
        LayoutRebuilder.ForceRebuildLayoutImmediate(transform.parent.GetComponent<RectTransform>());
    }
}