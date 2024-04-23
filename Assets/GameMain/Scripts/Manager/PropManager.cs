using System.Collections.Generic;
using UnityEngine;

public class PropManager : MonoBehaviour
{
    private static PropManager _instance;

    public static void Init()
    {
        _instance = ManagerRoot.RootTransform.GetComponentInChildren<PropManager>();
    }

    private List<GameObject> _propCards = new();


    private void FixedUpdate()
    {
        foreach (var prop in _propCards)
        {
            var propState = prop.GetComponent<PropState>();
            if (!propState) continue;

            if (propState.ConsumeTimes >= propState.Model.MaxConsumeTimes)
            {
                propState.Model.OnRemove?.Invoke(prop);
                _propCards.Remove(prop);
                Destroy(prop);
            }
        }
    }


    //TODO:等预制体
    public static void CreateProp(PropCreator prop)
    {
        //var propObject = 预制体
        //_propCards.Add(propObject);
        //propObject.GetComponent<PropState>().InitByPropCreator(prop);
    }

    public static void RemoveProp(GameObject prop, bool isDestroy = false)
    {
        if (!prop) return;

        var propState = prop.GetComponent<PropState>();
        if (!propState) return;

        propState.ConsumeTimes = propState.Model.MaxConsumeTimes;
        if (isDestroy)
        {
            propState.Model.OnRemove?.Invoke(prop);
            propState.Model.OnDestroy?.Invoke(prop);
            _instance._propCards.Remove(prop);
            Destroy(prop);
        }
    }

    public static void ConsumeProp(GameObject prop)
    {
        if (!prop) return;

        var propState = prop.GetComponent<PropState>();
        if (!propState) return;

        propState.Model.OnConsume?.Invoke(prop);
        if (propState.IsConsumable)
            propState.ConsumeTimes++;
    }
}