using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class Select : MonoBehaviour, IPointerClickHandler
{
    private bool isFlipped;
    private Transform front;
    private Transform back;
    private TMP_Text ActionText;

    private void Start()
    {
        //获取需要显示在行动卡上的文字
        if (transform.name == "LeftAction")
        {
            ActionText.text = ManagerVariant.CurrentGameEvent().Model.GameActions[0].Name;
        }
        else if (transform.name == "RightAction")
        {
            ActionText.text = ManagerVariant.CurrentGameEvent().Model.GameActions[1].Name;
        }

        front = transform.GetChild(0);
        back = transform.GetChild(1);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        transform.GetComponentInParent<ActionSelect>().Click(transform.gameObject);
    }

    public void OnCardFlip()
    {
        RectTransform rect = GetComponent<RectTransform>();
        StartCoroutine(FlipCard(rect, isFlipped));
        isFlipped = !isFlipped;
    }
    IEnumerator FlipCard(RectTransform rect, bool isFlipped)
    {
        float duration = 1.0f;
        float t = 0;
        Quaternion startRotation = rect.rotation;
        Quaternion endRotation = startRotation * Quaternion.Euler(0, 180, 0);

        while (t < duration)
        {
            t += Time.deltaTime;
            float s = Mathf.Sin(Mathf.Clamp01(t / duration) * Mathf.PI * 0.5f);
            rect.rotation = Quaternion.Lerp(startRotation, endRotation, s);

            yield return null;
        }

        front.gameObject.SetActive(true);
        back.gameObject.SetActive(false);
    }

    public void FlipBack()
    {

            front.gameObject.SetActive(false);
            back.gameObject.SetActive(true);
            isFlipped = true;

    }

}
