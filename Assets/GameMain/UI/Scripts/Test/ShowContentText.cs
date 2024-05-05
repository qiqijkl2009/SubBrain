using System.Collections;
using System.Collections.Generic;
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

        //����Ч����
        DescriptionContent.text = "��������������˫��,ͷʹ���ѡ���������,�����Լ�����һ�ų¾ɵĲ����ϡ���������һ���ƾɵıʼǱ���һ֧�ֱʡ��ҷ����ʼǱ�,�������������һϵ�е���ıʼ�,���ҵ����ֱ�д����ˡ�������ɯ��";
    }

    //�л��¼�ʱ֪ͨ
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
