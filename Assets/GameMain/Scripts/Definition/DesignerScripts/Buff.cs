using System.Collections.Generic;

namespace DesignerScripts
{
    public class Buff
    {
        public static readonly Dictionary<string, BuffOnOccur> OnOccurFunc = new()
        {
        };

        public static readonly Dictionary<string, BuffOnRemove> OnRemoveFunc = new()
        {
        };

        public static readonly Dictionary<string, BuffOnTick> OnTickFunc = new()
        {
        };

        public static readonly Dictionary<string, BuffOnBeforeDead> OnBeforeDeadFunc = new()
        {
        };
    }
}