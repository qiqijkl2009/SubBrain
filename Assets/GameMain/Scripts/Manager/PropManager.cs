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
    private readonly List<GameObject> _selectedPropCards = new();

    private void FixedUpdate()
    {
        var toRemove = new List<GameObject>();

        foreach (var prop in _propCards)
        {
            var propState = prop.GetComponent<PropState>();
            if (!propState) continue;

            if (propState.ConsumeTimes >= propState.Model.MaxConsumeTimes)
            {
                propState.Model.OnRemove?.Invoke(prop);
                toRemove.Add(prop);
            }
        }

        if (toRemove.Count <= 0) return;

        foreach (var prop in toRemove)
        {
            _propCards.Remove(prop);
            Destroy(prop);
        }

        toRemove = null;
    }


    //TODO:等预制体
    public static void CreateProp(PropCreator prop)
    {
        //var propObject = 预制体
        //propObject.GetComponent<PropState>().InitByPropCreator(prop);
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
            _instance._propCards.Remove(prop);
            Destroy(prop);
        }
    }

    /// <summary>
    /// 使用一张道具卡
    /// </summary>
    /// <param name="prop">被使用的道具卡</param>
    public static void ConsumeProp(GameObject prop)
    {
        if (!prop) return;

        var propState = prop.GetComponent<PropState>();
        if (!propState) return;

        propState.Model.OnConsume?.Invoke(prop);
        if (propState.IsConsumable)
            propState.ConsumeTimes++;
    }

    /// <summary>
    /// 选择一张道具卡
    /// </summary>
    /// <param name="prop">被选择的道具卡</param>
    public static void SelectProp(GameObject prop)
    {
        if (_instance._selectedPropCards.Contains(prop)) return;
        if (!prop) return;

        var newPropState = prop.GetComponent<PropState>();
        if (!newPropState) return;

        foreach (var buff in newPropState.Model.Buffs)
        {
            ManagerVariant.AddBuff(buff);
        }

        _instance._selectedPropCards.Add(prop);
    }
    
    /// <summary>
    /// 取消一张道具卡的选择
    /// </summary>
    /// <param name="prop">被取消选择的道具卡</param>
    public static void UnselectProp(GameObject prop)
    {
        if (!_instance._selectedPropCards.Contains(prop)) return;
        if (!prop) return;

        var propState = prop.GetComponent<PropState>();
        if (!propState) return;

        foreach (var buff in propState.Model.Buffs)
        {
            ManagerVariant.AddBuff(buff.Opposite());
        }
        
        _instance._selectedPropCards.Remove(prop);
    }
}