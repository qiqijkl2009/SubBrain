using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using JKFrame;
using UnityEngine.UI;

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
                Transform propParent = GameObject.Find("PropCards").transform;
                var propCard = ManagerVariant.CreateProp(prop);
                propCard.transform.SetParent(propParent);
            }
        }

        private static void EndGame(GameEventObject gameEvent)
        {
            if (gameEvent == null) return;

            var gameActions = ManagerVariant.GameActions();
            if (gameActions[0]) Object.Destroy(gameActions[0]);
            if (gameActions[1]) Object.Destroy(gameActions[1]);

            var gameOverWindow = UISystem.Show<GameOverWindow>();
            var eventCard = GameObject.Find("CurrentEvent");
            eventCard.transform.SetParent(gameOverWindow.transform, false);
            eventCard.transform.DOScale(1.2f, 5f);
        }
    }
}