using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using JKFrame;
using DG.Tweening;
using UnityEngine.UI;

namespace DesignerScripts
{
    public class GameEvent
    {
        public static readonly Dictionary<string, GameEventOnCreate> OnCreateFunc = new()
        {
        };

        public static readonly Dictionary<string, GameEventOnEnter> OnEnterFunc = new()
        {
            { "GetProps", GetProps },
            { "EndGame", EndGame },
        };

        public static readonly Dictionary<string, GameEventOnLeave> OnLeaveFunc = new()
        {
 
        };


        private static void GetProps(GameEventObject gameEvent)
        {
            if (gameEvent == null) return;

            object[] args = gameEvent.Model.OnEnterArgs;

            var props = args.Length > 0 ? (PropCreator[])args[0] : null;

            if (props == null) return;
            
            foreach (var prop in props)
            {
                ManagerVariant.CreateProp(prop);
            }
        }

        private static void EndGame(GameEventObject gameEvent)
        {
            Debug.Log("进入结局");
            if (gameEvent == null) return;


            //Transform fadingMask = R.UIWindow.FadeOutMask_GameObject().transform;
            //Transform canvas = GameObject.Find("UICanvas").transform;
            //fadingMask.SetParent(canvas);
            Transform fadingMask = GameObject.Find("EndGameFade").transform;
            fadingMask.GetComponent<EndMenu>().StartFading();

            var currentCard = GameObject.Find("CurrentEvent");
            currentCard.transform.parent.GetComponentInChildren<UnitActionCard>().gameObject.SetActive(false);
            Vector3 originalPos = currentCard.transform.position;
            currentCard.transform.SetParent(fadingMask, false);
            currentCard.transform.SetAsLastSibling();
            currentCard.transform.DOScale(1.2f, 5f).OnComplete(() =>
            {
                fadingMask.GetComponentInChildren<Button>().gameObject.SetActive(true);
            });
        }
    }
}