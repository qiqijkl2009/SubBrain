using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

/// <summary>
/// 孩子不懂事乱写的
/// </summary>
public delegate void Refresh();

public static class Records
{
    public static Refresh refresh; 
    public static string RecordContents;
    public static int RoundCount = 1;
    public static int EventCount = 1;

    public static void TakeAction(string actionName)
    {
        RoundCount++;
        RecordContents += actionName + "\n" + "Event " + EventCount + " End" + "\n";
        EventCount++;
        refresh();
    }

    public static void UseProp(string propName)
    {
        RecordContents += "Used " + propName + "\n";
    }
}
