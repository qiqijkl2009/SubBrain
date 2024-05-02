using System;

public static class Records
{
    public static Action Refresh;
    public static Action ShowTalk;
    public static Action HideTalk;
    public static string RecordContents;
    public static int RoundCount = 1;
    public static int EventCount = 1;
    public static int EventType = 0;

    public static void TakeAction(string actionName)
    {
        RoundCount++;
        RecordContents += actionName + "\n" + "Event " + EventCount + " End" + "\n";
        EventCount++;
        Refresh?.Invoke();

        //对话系统目前取消
        //EventType = EventCount % 2;
        //if (EventType == 0)
        //{
        //    ShowTalk?.Invoke();
        //}
        //else
        //{
        //    HideTalk?.Invoke();
        //}
    }

    public static void UseProp(string propName)
    {
        RecordContents += "Used " + propName + "\n";
    }
}