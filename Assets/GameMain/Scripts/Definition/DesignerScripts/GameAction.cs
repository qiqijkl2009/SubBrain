using System.Collections.Generic;
using UnityEngine;

namespace DesignerScripts
{
    public class GameAction
    {
        public static readonly Dictionary<string, GameActionToEvent> ActionToEvent = new()
        {
            { "Test", e => new GameEventObject(DataTable.GameEvent.Data["Test"]) },
        };
    }
}