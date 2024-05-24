using System.Collections.Generic;

namespace DataTable
{
    public class GameScene
    {
        public static readonly Dictionary<string, GameSceneModel> Data = new()
        {
            {
                "Test", new GameSceneModel("Test", "测试", GameEvent.Data["Test"], new AddBuffInfo[]
                    {
                        new(Buff.Data["Test"], null, 1, 1)
                    },
                    "Test", null,
                    "Test", null,
                    "Test", null)
            }
        };
    }
}