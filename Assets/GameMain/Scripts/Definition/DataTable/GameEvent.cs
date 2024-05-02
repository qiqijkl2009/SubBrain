using System.Collections.Generic;

namespace DataTable
{
    public class GameEvent
    {
        public static Dictionary<string, GameEventModel> Data = new()
        {
            { "Test", new GameEventModel() },
            { "Event1", new GameEventModel("Event1", "Event1", null, 
                null, new GameEventUIInfo(),
                null, null,
                null, null,
                null, null) }
        };
    }
}