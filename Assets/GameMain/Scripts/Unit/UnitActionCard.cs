using System;
using System.Collections;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

/// <summary>
/// 行动卡控件，所有拥有交互操作的行动卡都应该添加这个来控制它
/// </summary>
public class UnitActionCard : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private Transform CardFront;
    [SerializeField] private Transform CardBack;
    [SerializeField] private TMP_Text ActionText;

    private bool _isFlipped;
    private Vector3 _originPosition;

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

    private void FixedUpdate()
    {
        
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Click(transform.gameObject);
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
    
    public void Click(GameObject actionObject)
    {
        GetComponent<Select>().enabled = false;

        actionObject.transform.SetAsLastSibling();

        GetComponent<ActionCardHover>().enabled = false;

        Records.TakeAction("Take " + actionObject.name);
        actionObject.GetComponentInChildren<TMP_Text>().text = "";

        // actionObject.transform.DOMove(_currentEvent.transform.position, 2f);
        actionObject.transform.DORotate(new Vector3(0, 0, 0), 2f);
        actionObject.transform.DOScaleX(1.75f, 2f);
        actionObject.transform.DOScaleY(1.1f, 2f);
        actionObject.GetComponent<Select>().OnCardFlip();
        // _isDone1 = false;

        // _currentAction = actionObject.transform;
    }

    public void BackToPosition()
    {
        transform.DOScale(1f, 1f);
        var gameActions = ManagerVariant.GameActions();

        if (gameActions[0] == gameObject) //左行动
        {
            transform.DOMove(_originPosition, 3f);
            transform.DORotate(new Vector3(0, 0, 10f), 5f);
            transform.GetComponentInChildren<TMP_Text>().text = "Action 1";
        }

        if (gameActions[1] == gameObject) //右行动
        {
            transform.DOMove(_originPosition, 3f);
            transform.DORotate(new Vector3(0, 0, -10f), 5f);
            transform.GetComponentInChildren<TMP_Text>().text = "Action 2";
        }

        FlipBack();
    }

    public void FlipBack()
    {
        CardFront.gameObject.SetActive(false);
        CardBack.gameObject.SetActive(true);
        _isFlipped = true;
    }
}