using System.Collections.Generic;

namespace DataTable
{
    public class GameAction
    {
        public static Dictionary<string, GameActionModel> Data = new()
        {
            {
                "Test", new GameActionModel("Test", "测试",
                    "Test", null)
            }
        };
    }
}