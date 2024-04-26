using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;

/// <summary>
/// 单位拖拽控件，所有需要拖拽功能的单位都应该添加这个来控制它的拖拽
/// </summary>
public class UnitDrag : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IDragHandler, IEndDragHandler
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

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
       
    }
}