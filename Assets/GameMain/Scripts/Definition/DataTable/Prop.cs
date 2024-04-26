using System.Collections.Generic;

namespace DataTable
{
    public class Prop
    {
        public static Dictionary<string, PropModel> Data = new()
        {
            {
                "Test", new PropModel("Test", "测试", null, 1, new PropUIInfo(), null,
                    "Test", null,
                    "Test", null,
                    "Test", null,
                    "Test", null)
            },
        };
    }
}