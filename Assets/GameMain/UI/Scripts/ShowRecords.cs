using UnityEngine;
using TMPro;

public class ShowRecords : MonoBehaviour
{
    [SerializeField] private TMP_Text RoundCount;
    [SerializeField] private TMP_Text RecordText;

    private void Awake()
    {
        Records.Refresh += RefreshText;
    }

    private void RefreshText()
    {
        RoundCount.text = "回合计数: " + Records.RoundCount;
        RecordText.text = Records.RecordContents;
    }
}