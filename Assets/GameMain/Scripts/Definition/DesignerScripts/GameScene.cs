using System.Collections.Generic;
using UnityEngine;

namespace DesignerScripts
{
    public class GameScene
    {
        public static readonly Dictionary<string, GameSceneOnCreate> OnCreateFunc = new()
        {
            { "Test", prop => { Debug.Log("场景添加方法测试"); } },
        };

        public static readonly Dictionary<string, GameSceneOnRemove> OnRemoveFunc = new()
        {
            { "Test", prop => { Debug.Log("场景移除方法测试"); } },
        };

        public static readonly Dictionary<string, GameSceneOnSelect> OnSelectFunc = new()
        {
            { "Test", prop => { Debug.Log("场景选择方法测试"); } },
        };
    }
}