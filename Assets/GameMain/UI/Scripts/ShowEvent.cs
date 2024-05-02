using UnityEngine;
using TMPro;
using UnityEngine.UI;
using JKFrame;

public class ShowEvent : MonoBehaviour
{
    [SerializeField] private TMP_Text EventText;
    [SerializeField] private Image EventImage;

    private void Start()
    {
        Records.Refresh += RefreshEvent;
        EventText = transform.GetChild(0).GetComponent<TextMeshProUGUI>();
        EventImage = transform.GetChild(1).GetComponent<Image>();
    }

    private void RefreshEvent()
    {
        EventText.text = ManagerVariant.CurrentGameEvent().Model.UIInfo.Title;

        string ImageID = ManagerVariant.CurrentGameEvent().Model.UIInfo.TextureId;
        EventImage.sprite = R.Texture.TestImage1_TestImage1;
    }
}