using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

/// <summary>
/// 单位卡片控件，所有拥有交互操作的卡片都应该添加这个来控制它
/// </summary>
public class UnitCard : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private Vector3 _originalPos;
    private Vector3 _offset;
    private bool _canUse;

    private void Start()
    {
        _originalPos = transform.position;
        _canUse = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        transform.DOScale(1.1f, 1f);
        transform.DORotate(new Vector3(0, 0, Random.Range(-2f, 2f)), 1f);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        transform.DOScale(1f, 1f);
        transform.DORotate(new Vector3(0, 0, 0), 1f);
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        transform.GetComponent<Image>().raycastTarget = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        GameObject EndObject = eventData.pointerCurrentRaycast.gameObject;
        Debug.Log(EndObject.transform.parent);

        //判断道具是否放在了事件卡上使用
        if (EndObject.transform.parent.tag == "EventCardArea")
        {
            //判断是否能在该事件中使用这个道具，不确定是否应该在这里进行判断
            //if (true)
            //{

            //}
            PropManager.RemoveProp(gameObject, true);
            Debug.Log("道具卡已被使用");
        }
        else
        {
            LayoutRebuilder.ForceRebuildLayoutImmediate(transform.parent.GetComponent<RectTransform>());
        }

        transform.GetComponent<Image>().raycastTarget = true;
    }
}