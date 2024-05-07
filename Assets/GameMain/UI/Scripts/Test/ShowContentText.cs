using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class ShowContentText : MonoBehaviour, IPointerClickHandler
{
    public TMP_Text DescriptionContent;
    public int ClickCount = 0;

    void Start()
    {
        //ContentText.text = GameEventManager.CurrentGameEvent.Model.UIInfo.Content;

        //测试效果用
        DescriptionContent.text = "我慢慢地睁开了双眼,头痛欲裂。环顾四周,发现自己躺在一张陈旧的病床上。手碰到了一本破旧的笔记本和一支钢笔。我翻开笔记本,发现上面记载着一系列调查的笔记,而我的名字被写在最顶端——艾丽莎。";
    }

    //切换事件时通知
    void RefreshContent()
    {
        ClickCount = 0;
        DescriptionContent.pageToDisplay = 1;
        DescriptionContent.text = GameCardManager.CurrentGameEvent.Model.UIInfo.Content;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (ClickCount < DescriptionContent.textInfo.pageCount - 1)
        {
            DescriptionContent.pageToDisplay += 1;
            ClickCount++;
        }
        else
        {
            ClickCount = 0;
            DescriptionContent.pageToDisplay = 1;
        }
    }
}
