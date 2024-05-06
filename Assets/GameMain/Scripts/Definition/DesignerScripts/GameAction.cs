using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace DesignerScripts
{
    public class GameAction
    {
        public static readonly Dictionary<string, GameActionToEvent> ActionToEvent = new()
        {
            { "Test", (_, _, _, _) => new GameEventObject(DataTable.GameEvent.Data["Test"]) },
            { "GetThatEvent", GetThatEvent },
            { "GetEventByBuff", GetEventByBuff },
        };


        private static GameEventObject GetThatEvent(GameObject gameAction, int waitRounds, bool isRepeat, bool isOnly)
        {
            var state = gameAction.GetComponent<ActionState>();
            if (!state) return null;

            object[] args = state.Model.GameActionArgs;

            string gameEventId = args.Length > 0 ? (string)args[0] : null;

            return gameEventId != null ? new GameEventObject(DataTable.GameEvent.Data[gameEventId], waitRounds, isRepeat, isOnly) : null;
        }

        private static GameEventObject GetEventByBuff(GameObject gameAction, int waitRounds, bool isRepeat, bool isOnly)
        {
            var state = gameAction.GetComponent<ActionState>();
            if (!state) return null;

            object[] args = state.Model.GameActionArgs;
            var buffs = ManagerVariant.Buffs();

            string[] gameEventIds = args.Length > 0 ? (string[])args[0] : null;
            string[] buffConditions = args.Length > 1 ? (string[])args[1] : null;

            if (gameEventIds == null || buffConditions == null) return null;

            for (int i = 0; i < buffConditions.Length; i++)
            {
                if (buffs.FirstOrDefault(buff => buff.Model.Id == buffConditions[i]) != null)
                {
                    return new GameEventObject(DataTable.GameEvent.Data[gameEventIds[i]], waitRounds, isRepeat, isOnly);
                }
            }

            return null;
        }
    }
}