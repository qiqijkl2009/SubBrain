using System.Collections.Generic;

namespace DataTable
{
    public class GameEvent
    {
        public static Dictionary<string, GameEventModel> Data = new()
        {
            {
                "Test", new GameEventModel("Test", "测试", null, new[] { GameAction.Data["Test"] }, new GameEventUIInfo("Test", "Test", "Test"),
                    "Test", null,
                    "Test", null,
                    "Test", null)
            }
        };
    }
}