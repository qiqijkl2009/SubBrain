using UnityEngine;

public class StatsManager : MonoBehaviour
{
    private static StatsManager _instance;

    public static void Init()
    {
        _instance = ManagerRoot.RootTransform.GetComponentInChildren<StatsManager>();
    }

    private CharacterResource _resource = new();

    /// <summary>
    /// 当前角色的资源类属性
    /// </summary>
    public static CharacterResource Resource
    {
        get => _instance._resource;
        private set => _instance._resource = value;
    }

    ///<summary>
    ///改变角色的资源类属性，
    ///<param name="value">要改变的量，负数为减少</param>
    ///</summary>
    public static void ModResource(CharacterResource value)
    {
        Resource += value;
        Resource.ExplorePoint = Mathf.Max(0, Resource.ExplorePoint);
    }
}