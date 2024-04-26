using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class TestGetProp : MonoBehaviour
{
    [SerializeField] private Button TestButton;
    [SerializeField] private Transform PropCardsParent;

    private void Start()
    {
        TestButton.onClick.AddListener(OnTestButtonClicked);
    }

    private void OnTestButtonClicked()
    {
        var prop = ManagerVariant.CreateProp(new PropCreator(DataTable.Prop.Data["Test"]));
        prop.transform.SetParent(PropCardsParent, false);
    }
}