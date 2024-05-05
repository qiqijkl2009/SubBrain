using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class TestAddEvent : MonoBehaviour
{
    [SerializeField] private Button TestButton;

    private void Start()
    {
        TestButton.onClick.AddListener(OnTestButtonClicked);
    }

    private void OnTestButtonClicked()
    {
        ManagerVariant.CreateGameEvent(DataTable.GameEvent.Data["WakeUp"]);
        ManagerVariant.RoundStart();
    }
}