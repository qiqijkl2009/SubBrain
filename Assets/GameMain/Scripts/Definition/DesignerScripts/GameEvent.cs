using System.Collections.Generic;
using UnityEngine;

namespace DesignerScripts
{
    public class GameEvent
    {
        public static readonly Dictionary<string, GameEventOnCreate> OnCreateFunc = new()
        {
            { "Test", @event => { Debug.Log("事件创建方法测试"); } },
        };

        public static readonly Dictionary<string, GameEventOnEnter> OnEnterFunc = new()
        {
            { "Test", @event => { Debug.Log("事件进入方法测试"); } },
        };

        public static readonly Dictionary<string, GameEventOnLeave> OnLeaveFunc = new()
        {
            { "Test", @event => { Debug.Log("事件退出方法测试"); } },
        };
    }
}