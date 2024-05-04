using System;
using System.Collections.Generic;

namespace DataTable
{
    public class Buff
    {
        public static Dictionary<string, BuffModel> Data = new()
        {
            {
                "Test", new BuffModel("Test", "测试", 0, 1, null, 1,
                    "Test", null,
                    "Test", null,
                    "Test", null,
                    "Test", null)
            },
            {
                " ExplorePoint", new BuffModel("ExplorePoint", "探索点", 0, 1, null, 0,
                    "", null,
                    "", null,
                    "", null,
                    "", null)
            },
        };
    }
}