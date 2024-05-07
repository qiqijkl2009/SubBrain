using UnityEngine;

public class ActionSelect : MonoBehaviour
{
    [SerializeField] private Transform TestContainer;

    private GameObject _leftAction;
    private GameObject _rightAction;


    private void Start()
    {

    }

    private void FixedUpdate()
    {
        var gameActions = ManagerVariant.GameActions();
        if (!_leftAction && gameActions[0])
        {
            _leftAction = gameActions[0];
            _leftAction.transform.SetParent(TestContainer);
            _leftAction.transform.SetAsFirstSibling();
        }

        if (!_rightAction && gameActions[1])
        {
            _rightAction = gameActions[1];
            _rightAction.transform.SetParent(TestContainer);
            _rightAction.transform.SetAsFirstSibling();
        }
    }
}