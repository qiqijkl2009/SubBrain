using System.Collections.Generic;

namespace DataTable
{
    public class GameAction
    {
        public static Dictionary<string, GameActionModel> Data = new()
        {
            {
                "Test", new GameActionModel("Test", "测试", new GameActionUIInfo(),
                    "Test", null)
            },
            {
                "努力回忆",
                new GameActionModel("努力回忆", "努力回忆", new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "Headache" })
            },
            {
                "放弃思考",
                new GameActionModel("放弃思考", "放弃思考", new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "Headache" })
            },
            {
                "观察左边",
                new GameActionModel("观察左边", "观察左边", new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "GetPhoto" })
            },
            {
                "观察右边",
                new GameActionModel("观察右边", "观察右边", new GameActionUIInfo(),
                    "GetThatEvent", new object[] { "GetPressCard" })
            },
            //{
            //    "静观其变",
            //    new GameActionModel("静观其变", "静观其变", new GameActionUIInfo(),
            //        "GetThatEvent", new object[] { "NurseEnterRoom" })
            //},
            //{
            //    "搜索房间",
            //    new GameActionModel("搜索房间", "搜索房间", new GameActionUIInfo(),
            //        "GetThatEvent", new object[] { "WhichToRummage" })
            //},
            //{
            //    "翻找床铺",
            //    new GameActionModel("翻找床铺", "翻找床铺", new GameActionUIInfo(),
            //        "GetThatEvent", new object[] { "NurseEnterRoom" })
            //},
            //{
            //    "翻找柜子",
            //    new GameActionModel("翻找柜子", "翻找柜子", new GameActionUIInfo(),
            //        "GetThatEvent", new object[] { "NurseEnterRoom" })
            //},
        };
    }
}