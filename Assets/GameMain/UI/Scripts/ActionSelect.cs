using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;

public class ActionSelect : MonoBehaviour
{
    private Image LeftAction;
    private Image RightAction;
    private Vector3 LeftPosition;
    private Vector3 RightPosition;
    private Transform CurrentAction;
    private Transform CurrentEventCard;
    private float Timer1;
    private bool IsDone1;
    private float Timer2;
    private bool IsDone2;

    // Start is called before the first frame update
    void Start()
    {
        LeftAction = transform.GetChild(0).GetComponent<Image>();
        RightAction = transform.GetChild(1).GetComponent<Image>();

        LeftPosition = LeftAction.transform.position;
        RightPosition = RightAction.transform.position;

        CurrentEventCard = transform.GetChild(2);
        IsDone1 = true;
        IsDone2 = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!IsDone1)
        {
            Timer1 += Time.deltaTime;
        }

        if (!IsDone2)
        {
            Timer2 += Time.deltaTime;
        }

        if (Timer1 >= 1f)
        {
            Timer1 = 0;
            IsDone1 = true;
            IsDone2 = false;

            BackToPosition(CurrentAction);
        }

        if (Timer2 >= 5f)
        {
            IsDone2 = true;
            Timer2 = 0;

            LeftAction.GetComponent<Select>().enabled = true;
            RightAction.GetComponent<Select>().enabled = true;
            LeftAction.GetComponent<ActionCardHover>().enabled = true;
            RightAction.GetComponent<ActionCardHover>().enabled = true;
        }
    }

    public void Click(GameObject actionObject)
    {
        //if (actionObject.name == "LeftAction")
        //{
        //    RightAction.GetComponent<Select>().enabled = false;
        //}
        //else if (actionObject.name == "RightAction")
        //{
        //    LeftAction.GetComponent<Select>().enabled = false;
        //}

        RightAction.GetComponent<Select>().enabled = false;
        LeftAction.GetComponent<Select>().enabled = false;

        actionObject.transform.SetAsLastSibling();

        LeftAction.transform.GetComponent<ActionCardHover>().enabled = false;
        RightAction.transform.GetComponent<ActionCardHover>().enabled = false;

        Records.TakeAction("Take " + actionObject.name);
        actionObject.GetComponentInChildren<TextMeshProUGUI>().text = "";

        actionObject.transform.DOMove(CurrentEventCard.transform.position, 1f);
        actionObject.transform.DORotate(new Vector3(0, 0, 0), 1f);
        actionObject.transform.DOScaleX(1.75f, 1f);
        actionObject.transform.DOScaleY(1.1f, 1f);
        IsDone1 = false;

        CurrentAction = actionObject.transform;
    }

    public void BackToPosition(Transform selectedAction)
    {
        selectedAction.SetAsFirstSibling();
        selectedAction.DOScaleX(1f, 1f);
        selectedAction.DOScaleY(1f, 1f);
        if (selectedAction.name == "LeftAction")
        {
            selectedAction.DOMove(LeftPosition, 3f);
            selectedAction.DORotate(new Vector3(0, 0, 10f), 5f);
            selectedAction.GetComponentInChildren<TextMeshProUGUI>().text = "Action 1";
        }
        else if (selectedAction.name == "RightAction")
        {
            selectedAction.DOMove(RightPosition, 3f);
            selectedAction.DORotate(new Vector3(0, 0, -10f), 5f);
            selectedAction.GetComponentInChildren<TextMeshProUGUI>().text = "Action 2";
        }
    }
}
