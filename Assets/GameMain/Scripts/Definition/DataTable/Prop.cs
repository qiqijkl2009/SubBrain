﻿using System.Collections.Generic;

namespace DataTable
{
    public class Prop
    {
        public static Dictionary<string, PropModel> Data = new()
        {
            {
                "Test", new PropModel("Test", "测试", null, 1, new PropUIInfo(), new AddBuffInfo[]
                    {
                        new(Buff.Data["Test"], null, 1, 1)
                    },
                    "Test", null,
                    "Test", null,
                    "Test", null,
                    "Test", null)
            },
        };
    }
}