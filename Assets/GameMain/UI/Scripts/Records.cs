using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

/// <summary>
/// 孩子不懂事乱写的
/// </summary>
public delegate void Refresh();
public delegate void ShowTalk();
public delegate void HideTalk();

public static class Records
{
    public static Refresh refresh;
    public static ShowTalk showTalk;
    public static HideTalk hideTalk;
    public static string RecordContents;
    public static int RoundCount = 1;
    public static int EventCount = 1;
    public static int EventType = 0;

    public static void TakeAction(string actionName)
    {
        RoundCount++;
        RecordContents += actionName + "\n" + "Event " + EventCount + " End" + "\n";
        EventCount++;
        refresh();

        EventType = EventCount % 2;
        if (EventType == 0)
        {
            showTalk();
        }
        else
        {
            hideTalk();
        }
    }

    public static void UseProp(string propName)
    {
        RecordContents += "Used " + propName + "\n";
    }
}
