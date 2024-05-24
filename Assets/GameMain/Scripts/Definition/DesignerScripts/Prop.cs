using System.Collections.Generic;
using UnityEngine;

namespace DesignerScripts
{
    public class Prop
    {
        public static readonly Dictionary<string, PropOnCreate> OnCreateFunc = new()
        {
        };

        public static readonly Dictionary<string, PropOnRemove> OnRemoveFunc = new()
        {
        };

        public static readonly Dictionary<string, PropOnConsume> OnConsumeFunc = new()
        {
            { "ChangeEvent", ChangeEvent },
        };

        public static readonly Dictionary<string, PropOnDestroy> OnDestroyFunc = new()
        {
        };


        private static bool ChangeEvent(GameObject prop)
        {
            var state = prop.GetComponent<PropState>();
            if (!state) return false;

            object[] args = state.Model.OnConsumeArgs;

            string[] gameEventObjects = args.Length > 0 ? (string[])args[0] : null;
            string[] gameEventConditions = args.Length > 1 ? (string[])args[1] : null;

            if (gameEventObjects == null || gameEventConditions == null) return false;

            for (int i = 0; i < gameEventConditions.Length; i++)
            {
                if (ManagerVariant.CurrentGameEvent().Model.Id != gameEventConditions[i]) continue;

                var gameEventObject = new GameEventObject(DataTable.GameEvent.Data[gameEventObjects[i]]);
                ManagerVariant.SetCurrentGameEvent(gameEventObject);
                return true;
            }

            return false;
        }
    }
}