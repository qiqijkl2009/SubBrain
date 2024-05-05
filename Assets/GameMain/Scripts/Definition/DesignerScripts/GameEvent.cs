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
            { "GetProps", GetProps },
        };

        public static readonly Dictionary<string, GameEventOnLeave> OnLeaveFunc = new()
        {
            { "Test", @event => { Debug.Log("事件退出方法测试"); } },
        };


        private static void GetProps(GameEventObject gameEvent)
        {
            if (gameEvent == null) return;

            object[] args = gameEvent.Model.OnEnterArgs;

            var props = args.Length > 0 ? (PropCreator[])args[0] : null;

            if (props == null) return;
            
            foreach (var prop in props)
            {
                ManagerVariant.CreateProp(prop);
            }
        }
    }
}