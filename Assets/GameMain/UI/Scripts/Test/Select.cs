using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class Select : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private Transform CardFront;
    [SerializeField] private Transform CardBack;
    [SerializeField] private TMP_Text ActionText;
    
    private bool _isFlipped;

    private void Start()
    {
        //获取需要显示在行动卡上的文字
        var gameActions = ManagerVariant.GameActions();
        if (transform.name == "LeftAction")
        {
            ActionText.text = gameActions[0].name;
        }
        else if (transform.name == "RightAction")
        {
            ActionText.text = gameActions[1].name;
        }
    }
    
    public void OnPointerClick(PointerEventData eventData)
    {
        // Click(transform.gameObject);
    }

    public void OnCardFlip()
    {
        var rect = GetComponent<RectTransform>();
        StartCoroutine(FlipCard(rect, _isFlipped));
        _isFlipped = !_isFlipped;
    }

    private IEnumerator FlipCard(RectTransform rect, bool isFlipped)
    {
        float duration = 1.0f;
        float t = 0;
        var startRotation = rect.rotation;
        var endRotation = startRotation * Quaternion.Euler(0, 180, 0);

        while (t < duration)
        {
            t += Time.deltaTime;
            float s = Mathf.Sin(Mathf.Clamp01(t / duration) * Mathf.PI * 0.5f);
            rect.rotation = Quaternion.Lerp(startRotation, endRotation, s);

            yield return null;
        }

        CardFront.gameObject.SetActive(true);
        CardBack.gameObject.SetActive(false);
    }

    public void FlipBack()
    {
        CardFront.gameObject.SetActive(false);
        CardBack.gameObject.SetActive(true);
        _isFlipped = true;
    }
}