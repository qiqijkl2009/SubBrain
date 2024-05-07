using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class TestFlip : MonoBehaviour, IPointerClickHandler
{
    private bool isFlipped;
    private Transform front;
    private Transform back;
    private TMP_Text ActionText;

    private void Start()
    {
        front = transform.GetChild(0);
        back = transform.GetChild(1);
        ActionText = transform.GetComponentInChildren<TMP_Text>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        transform.GetComponentInParent<TestActionSelect>().Click(transform.gameObject);
    }

    public void OnCardFlip()
    {
        RectTransform rect = GetComponent<RectTransform>();
        StartCoroutine(FlipCard(rect, isFlipped));
        isFlipped = !isFlipped;
    }
    IEnumerator FlipCard(RectTransform rect, bool isFlipped)
    {
        float duration = 0.5f;
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

    public void Flip()
    {
        front.gameObject.SetActive(true);
        back.gameObject.SetActive(false);
        isFlipped = true;
        ActionText.gameObject.SetActive(false);
    }

    public void FlipBack()
    {
        front.gameObject.SetActive(false);
        back.gameObject.SetActive(true);
        isFlipped = true;
        ActionText.gameObject.SetActive(true);
    }

}
