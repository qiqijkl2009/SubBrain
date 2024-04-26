using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using DG.Tweening;

public class TalkOption : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    private Image Character;
    private bool IsRevealed;
    private Transform TextArea;

    private void Awake()
    {
        Records.ShowTalk += ShowTalk;
        Records.HideTalk += HideTalk;
    }

    // Start is called before the first frame update
    void Start()
    {
        Character = GetComponent<Image>();
        HideTalk();

        TextArea = transform.GetChild(0);
    }

    // Update is called once per frame
    void Update()
    {
        if (IsRevealed == false)
        {
            TextArea.gameObject.SetActive(false);

        }
    }

    private void ShowTalk()
    {
        Character.enabled = true;
        Character.color = Color.black;
        IsRevealed = true;
    }

    private void HideTalk()
    {
        Character.enabled = false;
        IsRevealed = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Character.transform.DOScale(1.1f, 0.5f);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Character.transform.DOScale(1.0f, 0.5f);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Character.DOColor(Color.white, 1f);
        TextArea.gameObject.SetActive(true);
    }
}
