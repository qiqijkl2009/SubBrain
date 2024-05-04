using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;

public class ActionSelect : MonoBehaviour
{
    [SerializeField] private Transform TestContainer;

    private GameObject _leftAction;
    private GameObject _rightAction;

    private Vector3 _leftPosition;
    private Vector3 _rightPosition;
    private Transform _currentAction;
    private Transform _currentEventCard;
    private float _timer1;
    private bool _isDone1;
    private float _timer2;
    private bool _isDone2;


    private void Start()
    {
        _leftPosition = _leftAction.transform.position;
        _rightPosition = _rightAction.transform.position;

        _currentEventCard = transform.GetChild(2);
        _isDone1 = true;
        _isDone2 = true;
    }

    private void FixedUpdate()
    {
        var gameActions = ManagerVariant.GameActions();
        if (!_leftAction && gameActions[0])
        {
            _leftAction = gameActions[0];
            _leftAction.transform.SetParent(TestContainer);
        }

        if (!_rightAction && gameActions[1])
        {
            _rightAction = gameActions[1];
            _rightAction.transform.SetParent(TestContainer);
        }
    }

    private void Update()
    {
        if (!_isDone1)
        {
            _timer1 += Time.deltaTime;
        }

        if (!_isDone2)
        {
            _timer2 += Time.deltaTime;
        }

        if (_timer1 >= 2f)
        {
            _timer1 = 0;
            _isDone1 = true;
            _isDone2 = false;

            BackToPosition(_currentAction);
        }

        if (_timer2 >= 3f)
        {
            _isDone2 = true;
            _timer2 = 0;

            _leftAction.GetComponent<Select>().enabled = true;
            _rightAction.GetComponent<Select>().enabled = true;
            _leftAction.GetComponent<ActionCardHover>().enabled = true;
            _rightAction.GetComponent<ActionCardHover>().enabled = true;
        }
    }

    public void Click(GameObject actionObject)
    {
        _rightAction.GetComponent<Select>().enabled = false;
        _leftAction.GetComponent<Select>().enabled = false;

        actionObject.transform.SetAsLastSibling();

        _leftAction.transform.GetComponent<ActionCardHover>().enabled = false;
        _rightAction.transform.GetComponent<ActionCardHover>().enabled = false;

        Records.TakeAction("Take " + actionObject.name);
        actionObject.GetComponentInChildren<TextMeshProUGUI>().text = "";

        actionObject.transform.DOMove(_currentEventCard.transform.position, 2f);
        actionObject.transform.DORotate(new Vector3(0, 0, 0), 2f);
        actionObject.transform.DOScaleX(1.75f, 2f);
        actionObject.transform.DOScaleY(1.1f, 2f);
        actionObject.GetComponent<Select>().OnCardFlip();
        _isDone1 = false;

        _currentAction = actionObject.transform;
    }

    public void BackToPosition(Transform selectedAction)
    {
        selectedAction.SetAsFirstSibling();
        selectedAction.DOScaleX(1f, 1f);
        selectedAction.DOScaleY(1f, 1f);
        if (selectedAction.name == "LeftAction")
        {
            selectedAction.DOMove(_leftPosition, 3f);
            selectedAction.DORotate(new Vector3(0, 0, 10f), 5f);
            selectedAction.GetComponentInChildren<TextMeshProUGUI>().text = "Action 1";
        }
        else if (selectedAction.name == "RightAction")
        {
            selectedAction.DOMove(_rightPosition, 3f);
            selectedAction.DORotate(new Vector3(0, 0, -10f), 5f);
            selectedAction.GetComponentInChildren<TextMeshProUGUI>().text = "Action 2";
        }

        selectedAction.GetComponent<Select>().FlipBack();
    }
}