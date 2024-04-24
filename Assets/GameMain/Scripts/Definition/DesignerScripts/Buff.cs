using System.Collections.Generic;
using UnityEngine;

namespace DesignerScripts
{
    public class Buff
    {
        public static readonly Dictionary<string, BuffOnOccur> OnOccurFunc = new()
        {
            { "Test", (buff, ssd) => { Debug.Log("buff添加方法测试"); } },
        };

        public static readonly Dictionary<string, BuffOnRemove> OnRemoveFunc = new()
        {
            { "Test", buff => { Debug.Log("buff移除方法测试"); } },
        };

        public static readonly Dictionary<string, BuffOnTick> OnTickFunc = new()
        {
            { "Test", buff => { Debug.Log("buff生效方法测试"); } },
        };

        public static readonly Dictionary<string, BuffOnBeforeDead> OnBeforeDeadFunc = new()
        {
            { "Test", buff => { Debug.Log("buff亡语方法测试"); } },
        };
    }
}