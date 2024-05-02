using UnityEngine;
using TMPro;
using UnityEngine.UI;
using JKFrame;

public class ShowEvent : MonoBehaviour
{
    [SerializeField] private TMP_Text EventTitle;
    [SerializeField] private TMP_Text EventContent;
    [SerializeField] private Image EventImage;

    private void Start()
    {
        Records.Refresh += RefreshEvent;
        EventTitle = transform.GetChild(0).GetComponent<TextMeshProUGUI>();
        EventImage = transform.GetChild(1).GetComponent<Image>();
        EventContent = transform.GetChild(2).GetComponent<TextMeshProUGUI>();
    }

    public void RefreshEvent()
    {
        EventTitle.text = ManagerVariant.CurrentGameEvent().Model.UIInfo.Title;

        string ImageID = ManagerVariant.CurrentGameEvent().Model.UIInfo.TextureId;
        EventImage.sprite = ResSystem.LoadAsset<Sprite>(ImageID);

        EventContent.text = ManagerVariant.CurrentGameEvent().Model.UIInfo.Content;
    }
}