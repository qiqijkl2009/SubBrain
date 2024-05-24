using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using JKFrame;

namespace DesignerScripts
{
    public class GameEvent
    {
        public static readonly Dictionary<string, GameEventOnCreate> OnCreateFunc = new()
        {
        };

        public static readonly Dictionary<string, GameEventOnEnter> OnEnterFunc = new()
        {
            { "GetProps", GetProps },
            { "EndGame", EndGame },
        };

        public static readonly Dictionary<string, GameEventOnLeave> OnLeaveFunc = new()
        {
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

        private static void EndGame(GameEventObject gameEvent)
        {
            if (gameEvent == null) return;

            var gameActions = ManagerVariant.GameActions();
            if (gameActions[0]) Object.Destroy(gameActions[0]);
            if (gameActions[1]) Object.Destroy(gameActions[1]);

            EventSystem.EventTrigger(GameConstant.ScriptEvent.END_GAME);
        }
    }
}