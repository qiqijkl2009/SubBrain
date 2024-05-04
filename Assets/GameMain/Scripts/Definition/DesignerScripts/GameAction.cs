using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace DesignerScripts
{
    public class GameAction
    {
        public static readonly Dictionary<string, GameActionToEvent> ActionToEvent = new()
        {
            { "Test", e => new GameEventObject(DataTable.GameEvent.Data["Test"]) },
            { "GetThatEvent", GetThatEvent },
        };


        private static GameEventObject GetThatEvent(GameObject gameAction)
        {
            var state = gameAction.GetComponent<ActionState>();
            if (!state) return null;

            object[] args = state.Model.GameActionArgs;

            var gameEvent = args.Length > 0 ? (GameEventObject)args[0] : null;

            return gameEvent;
        }

        private static GameEventObject GetEventByBuff(GameObject gameAction)
        {
            var state = gameAction.GetComponent<ActionState>();
            if (!state) return null;

            object[] args = state.Model.GameActionArgs;
            var buffs = ManagerVariant.Buffs();

            var gameEvents = args.Length > 0 ? (GameEventObject[])args[0] : null;
            string[] buffConditions = args.Length > 1 ? (string[])args[1] : null;

            if (gameEvents == null || buffConditions == null) return null;

            for (int i = 0; i < buffConditions.Length; i++)
            {
                if (buffs.FirstOrDefault(buff => buff.Model.Id == buffConditions[i]) != null)
                {
                    return gameEvents[i];
                }
            }

            return null;
        }
    }
}