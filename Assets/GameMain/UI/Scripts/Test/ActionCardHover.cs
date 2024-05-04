using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
using DG.Tweening;

public class ActionCardHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private TextMeshProUGUI ActionName;
    private Image ActionCard;
    private Vector3 ActionCardPostion;

    // Start is called before the first frame update
    void Start()
    {
        ActionCard = GetComponent<Image>();
        ActionCardPostion = transform.position;

        ActionName = GetComponentInChildren<TextMeshProUGUI>();
        if (transform.name == "LeftAction")
        {
            ActionName.text = "Action 1";
        }
        else if (transform.name == "RightAction")
        {
            ActionName.text = "Action 2";
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (eventData.pointerEnter.transform.parent.name == "LeftAction")
        {
            Vector3 MoveLeft = new Vector3(-10f, 0, 0) + ActionCardPostion;
            ActionCard.transform.DOMove(MoveLeft, 0.5f);
        }
        else if (eventData.pointerEnter.transform.parent.name == "RightAction")
        {
            Vector3 MoveRight = new Vector3(10f, 0, 0) + ActionCardPostion;
            ActionCard.transform.DOMove(MoveRight, 0.5f);
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        ActionCard.transform.DOMove(ActionCardPostion, 0.5f);
    }
}
