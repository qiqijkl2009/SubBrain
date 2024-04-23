using UnityEngine;
using TMPro;

public class ShowEvent : MonoBehaviour
{
    private TextMeshProUGUI EventText;

    private void Awake()
    {
        Records.Refresh += RefreshEvent;
    }

    // Start is called before the first frame update
    void Start()
    {
        EventText = transform.GetChild(0).GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void RefreshEvent()
    {
        EventText.text = "Event " + Records.EventCount;
    }
}
