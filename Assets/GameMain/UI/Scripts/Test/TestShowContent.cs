using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TestShowContent : MonoBehaviour
{
    public TMP_Text ContentText;
    public int ClickCount = 0;

    void Start()
    {
        if (ContentText == null) return;

        //之后改成从事件里获取
        //ContentText.text = GameEventManager.CurrentGameEvent.Model.UIInfo.Content;
        ContentText.text = "我慢慢地睁开了双眼,头痛欲裂。环顾四周,发现自己躺在一张陈旧的病床上。手碰到了一本破旧的笔记本和一支钢笔。我翻开笔记本,发现上面记载着一系列调查的笔记,而我的名字被写在最顶端——艾丽莎。";

    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (ClickCount < ContentText.textInfo.pageCount - 1)
            {
                ContentText.pageToDisplay += 1;
                ClickCount++;
                Debug.Log("文字翻页");
            }
        }
    }

    
}
