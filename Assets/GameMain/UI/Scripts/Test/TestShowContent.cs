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

        //֮��ĳɴ��¼����ȡ
        //ContentText.text = GameEventManager.CurrentGameEvent.Model.UIInfo.Content;
        ContentText.text = "��������������˫��,ͷʹ���ѡ���������,�����Լ�����һ�ų¾ɵĲ����ϡ���������һ���ƾɵıʼǱ���һ֧�ֱʡ��ҷ����ʼǱ�,�������������һϵ�е���ıʼ�,���ҵ����ֱ�д����ˡ�������ɯ��";

    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (ClickCount < ContentText.textInfo.pageCount - 1)
            {
                ContentText.pageToDisplay += 1;
                ClickCount++;
                Debug.Log("���ַ�ҳ");
            }
        }
    }

    
}
