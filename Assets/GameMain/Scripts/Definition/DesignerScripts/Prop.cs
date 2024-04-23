using System.Collections.Generic;
using UnityEngine;

namespace DesignerScripts
{
    public class Prop
    {
        public static readonly Dictionary<string, PropOnCreate> OnCreateFunc = new()
        {
            { "Test", prop => { Debug.Log("道具添加方法测试"); } },
        };
        public static readonly Dictionary<string, PropOnRemove> OnRemoveFunc = new()
        {
            { "Test", prop => { Debug.Log("道具移除方法测试"); } },
        };
        public static readonly Dictionary<string, PropOnConsume> OnConsumeFunc = new()
        {
            { "Test", prop => { Debug.Log("道具使用方法测试"); } },
        };
        public static readonly Dictionary<string, PropOnDestroy> OnDestroyFunc = new()
        {
            { "Test", prop => { Debug.Log("道具摧毁方法测试"); } },
        };
    }
}