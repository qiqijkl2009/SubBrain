using UnityEngine;

public class EventPanel : MonoBehaviour
{
    [SerializeField] private Transform _leftActionPivot;
    [SerializeField] private Transform _rightActionPivot;

    private GameObject _leftAction;
    private GameObject _rightAction;

    private void Update()
    {
        if (_leftAction) return;
        
        var gameActions = ManagerVariant.GameActions();
        if (gameActions[0])
        {
            _leftAction = gameActions[0];
            _leftAction.transform.position = transform.position;
            _leftAction.transform.SetParent(_leftActionPivot, true);
            _leftAction.GetComponent<UnitActionCard>().ReturnToPivot();
        }
        
        if (_rightAction) return;

        if (gameActions[1])
        {
            _rightAction = gameActions[1];
            _rightAction.transform.position = transform.position;
            _rightAction.transform.SetParent(_rightActionPivot, true);
            _rightAction.GetComponent<UnitActionCard>().ReturnToPivot();
        }
    }
}