using System;
using System.Collections.Generic;
using UnityEngine;

public class PropManager : MonoBehaviour
{
    private static PropManager _instance;

    public static void Init()
    {
        _instance = ManagerRoot.RootTransform.GetComponentInChildren<PropManager>();
    }

    private readonly List<GameObject> _propCards = new();

    public static List<GameObject> PropCards => _instance._propCards;


    private void FixedUpdate()
    {
        var toRemove = new List<GameObject>();

        foreach (var prop in _propCards)
        {
            var propState = prop.GetComponent<PropState>();
            if (!propState) continue;
            if (propState.ConsumeTimes < propState.Model.MaxConsumeTimes) continue;

            propState.Model.OnRemove?.Invoke(prop);
            var buffs = propState.Model.Buffs;
            if (buffs != null)
            {
                foreach (var buff in buffs)
                {
                    ManagerVariant.AddBuff(buff.Opposite());
                }
            }
                
            toRemove.Add(prop);
        }

        if (toRemove.Count <= 0) return;

        foreach (var prop in toRemove)
        {
            _propCards.Remove(prop);
            Destroy(prop);
        }

        toRemove = null;
    }


    /// <summary>
    /// 添加一张道具卡
    /// </summary>
    /// <param name="prop">被添加的道具卡信息</param>
    /// <returns>创建出的道具卡实例</returns>
    public static GameObject CreateProp(PropCreator prop)
    {
        var propObject = R.Card.PropCard_GameObject();  
        var propState = propObject.GetComponent<PropState>();

        propState.InitByPropCreator(prop);
        propState.Model.OnCreate?.Invoke(propObject);
        PropCards.Add(propObject);

        var buffs = propState.Model.Buffs;
        if (buffs != null)
        {
            foreach (var buff in buffs)
            {
                ManagerVariant.AddBuff(buff);
            }
        }

        return propObject;
    }

    /// <summary>
    /// 移除一张道具卡
    /// </summary>
    /// <param name="prop">被移除的道具卡</param>
    /// <param name="isDestroy">是否为强制移除（无视使用次数）</param>
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
            PropCards.Remove(prop);
            Destroy(prop);
        }
    }
}