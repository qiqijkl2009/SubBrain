using UnityEngine;

/// <summary>
/// 道具的“状态”，是一个道具的总的“调控中心”
/// </summary>
public class PropState : MonoBehaviour
{
    /// <summary>
    /// 这是个什么道具
    /// </summary>
    public PropModel Model;

    /// <summary>
    /// 是否是一个消耗品，非消耗品的ConsumeTimes不会增加，即使=false，当使用次数达到上限后仍会被移除
    /// </summary>
    public bool IsConsumable;

    /// <summary>
    /// 当前使用次数
    /// </summary>
    public int ConsumeTimes = 0;

    /// <summary>
    /// 当前是否为待使用状态
    /// </summary>
    public bool IsSelected = false;

    [SerializeField] private GameObject _viewContainer;
    

    public void InitByPropCreator(PropCreator prop)
    {
        Model = prop.Model;
        IsConsumable = prop.IsConsumable;

        SyncUnitComponents();
    }

    private void SyncUnitComponents()
    {
        if (!_viewContainer) _viewContainer = GetComponentInChildren<ViewContainer>().gameObject;
    }


    /// <summary>
    /// 使用这个道具卡
    /// </summary>
    public void ConsumeProp()
    {
        Model.OnConsume?.Invoke(gameObject);
        if (IsConsumable) ConsumeTimes++;
    }
}