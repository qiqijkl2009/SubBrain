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
            { "ChangeEvent", ChangeEvent },
        };

        public static readonly Dictionary<string, PropOnDestroy> OnDestroyFunc = new()
        {
            { "Test", prop => { Debug.Log("道具摧毁方法测试"); } },
        };

        
        private static void ChangeEvent(GameObject prop)
        {
            var state = prop.GetComponent<PropState>();
            if (!state) return;

            object[] args = state.Model.OnConsumeArgs;
            var currentGameEvent = ManagerVariant.CurrentGameEvent();

            var gameEventObjects = args.Length > 0 ? (GameEventObject[])args[0] : null;
            string[] gameEventConditions = args.Length > 1 ? (string[])args[1] : null;

            if (gameEventObjects == null || gameEventConditions == null) return;

            for (int i = 0; i < gameEventConditions.Length; i++)
            {
                if (currentGameEvent.Model.Id == gameEventConditions[i])
                {
                    currentGameEvent = gameEventObjects[i];
                }
            }
        }
    }
}