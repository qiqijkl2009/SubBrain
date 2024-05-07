using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

/// <summary>
/// 行动卡控件，所有拥有交互操作的行动卡都应该添加这个来控制它
/// </summary>
public class UnitActionCard : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private Transform CardFront;
    [SerializeField] private Transform CardBack;
    [SerializeField] private TMP_Text ActionText;

    [SerializeField] private Vector3 CurrentEventPosition;
    [SerializeField] private Vector3 LeftPostion;
    [SerializeField] private Vector3 RightPostion;
    [SerializeField] private Vector3 HoverMoveValue = new Vector3(20f, 0, 0);
    [SerializeField] private Vector3 RotationValue = new Vector3(0, 0, 10f);
    [SerializeField] private float ScaleX;
    [SerializeField] private float ScaleY;

    [SerializeField] private Transform OtherAction;

    private bool _isMoving = false;

    private void Start()
    {
        //获取需要显示在行动卡上的文字
        if (transform.name == "LeftAction")
        {
            ActionText.text = ManagerVariant.CurrentGameEvent().Model.GameActions[0].Name;
            if (GameObject.Find("RightAction") != null)
            {
                OtherAction = GameObject.Find("RightAction").transform;
            }
        }
        else if (transform.name == "RightAction")
        {
            ActionText.text = ManagerVariant.CurrentGameEvent().Model.GameActions[1].Name;
            if (GameObject.Find("LeftAction") != null)
            {
                OtherAction = GameObject.Find("LeftAction").transform;
            }
        }

        CurrentEventPosition = GameObject.Find("CurrentEvent").transform.position;
        LeftPostion += CurrentEventPosition;
        RightPostion += CurrentEventPosition;
        transform.position = CurrentEventPosition;

        BackToPosition();
    }

    private void FixedUpdate()
    {
        
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (_isMoving)
        {
            return;
        }

        //Click(transform.gameObject);
        GameObject clone = Instantiate(gameObject);
        gameObject.SetActive(false);
        clone.transform.SetParent(transform.parent);
        clone.transform.position = transform.position;
        clone.transform.rotation = transform.rotation;
        clone.GetComponent<UnitActionCard>().Click(clone);

        transform.DOScaleY(1f, 2f).OnComplete(() =>
        {
            transform.GetComponent<ActionState>().TakeAction();
            clone.transform.DOKill();
            Destroy(clone, 0.5f);
        });

        if (OtherAction != null)
        {
            OtherAction.GetComponent<UnitActionCard>().enabled = false;
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (_isMoving)
        {
            return;
        }
        HoverMove(eventData, HoverMoveValue);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        HoverMove(eventData, Vector3.zero);
    }

    public void Click(GameObject actionObject)
    {
        if (_isMoving)
        {
            return;
        }

        _isMoving = true;
        GameManager.IsActionCardMoving = true;

        actionObject.transform.SetAsLastSibling();

        //Records.TakeAction("Take " + actionObject.name);
        actionObject.GetComponentInChildren<TMP_Text>().text = "";

        actionObject.transform.DOMove(CurrentEventPosition, 2f);
        //actionObject.transform.DORotate(new Vector3(0, 0, 0), 1f);

        actionObject.transform.DORotate(new Vector3(0, 90, 0), 1f).OnComplete(() =>
        {
            Flip();
            actionObject.transform.DORotate(new Vector3(0, 180, 0), 1f);
        });

        actionObject.transform.DOScaleX(ScaleX, 2f);
        actionObject.transform.DOScaleY(ScaleY, 2f).OnComplete(() =>
        {
            actionObject.transform.SetAsFirstSibling();
            _isMoving = false;
            GameManager.IsActionCardMoving = false;
            transform.DOKill();
            Destroy(this);
        });
    }

    public void HoverMove(PointerEventData eventData, Vector3 moveValue)
    {
        if (_isMoving)
        {
            return;
        }

        GameObject actionObject = eventData.pointerEnter.transform.GetComponentInParent<UnitActionCard>().gameObject;

        Vector3 Move = new Vector3();

        if (actionObject.name == "LeftAction")
        {
            Move = -moveValue + LeftPostion;
        }
        else if (actionObject.name == "RightAction")
        {
            Move = moveValue + RightPostion;
        }
        transform.DOMove(Move, 0.5f);
    }

    public void BackToPosition()
    {
        if (_isMoving)
        {
            return;
        }

        _isMoving = true;
        GameManager.IsActionCardMoving = true;

        transform.DOScale(1f, 1f);
        var gameActions = ManagerVariant.GameActions();

        if (gameActions[0] == gameObject) //左行动
        {
            transform.DOMove(LeftPostion, 3f).OnComplete(() =>
            {
                _isMoving = false;
                GameManager.IsActionCardMoving = false;
            });
            transform.DORotate(RotationValue, 5f);
        }

        if (gameActions[1] == gameObject) //右行动
        {
            transform.DOMove(RightPostion, 3f).OnComplete(() =>
            {
                _isMoving = false;
                GameManager.IsActionCardMoving = false;
            });
            transform.DORotate(-RotationValue, 5f);
        }

        FlipBack();
    }

    public void Flip()
    {
        CardFront.gameObject.SetActive(true);
        CardBack.gameObject.SetActive(false);
        ActionText.gameObject.SetActive(false);
    }

    public void FlipBack()
    {
        CardFront.gameObject.SetActive(false);
        CardBack.gameObject.SetActive(true);
        ActionText.gameObject.SetActive(true);
    }


}