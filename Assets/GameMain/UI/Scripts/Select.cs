using UnityEngine;
using UnityEngine.EventSystems;

public class Select : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        transform.GetComponentInParent<ActionSelect>().Click(transform.gameObject);
    }

}
