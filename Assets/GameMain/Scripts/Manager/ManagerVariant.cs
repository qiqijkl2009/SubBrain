using System.Collections.Generic;
using UnityEngine;

public class ManagerVariant
{
    public static void CreateGameEvent(AddGameEventInfo ageInfo)
    {
        GameEventManager.CreateGameEvent(ageInfo);
    }

    #region Buff相关

    /// <summary>
    /// 为角色添加buff，删除buff也是走这个的，只不过删除的流程不在这里处理
    /// </summary>
    /// <param name="buff">要改变的Buff</param>
    public static void AddBuff(AddBuffInfo buff)
    {
        BuffManager.AddBuff(buff);
    }

    ///<summary>
    ///获取角色身上对应的BuffObject
    ///<param name="id">Buff的Model的Id</param>
    ///<param name="source">如果source不为空，那么就代表只有BuffObject.Source在source里面的才符合条件</param>
    ///<return>符合条件的BuffObject数组</return>
    ///</summary>
    public static List<BuffObject> GetBuffById(string id, List<GameObject> source = null)
    {
        return BuffManager.GetBuffById(id, source);
    }

    #endregion

    #region 道具相关

    /// <summary>
    /// 创建一张道具卡
    /// </summary>
    /// <param name="prop">要创建的道具卡信息</param>
    public static void CreateProp(PropCreator prop)
    {
        PropManager.CreateProp(prop);
    }

    /// <summary>
    /// 移除一张道具卡
    /// </summary>
    /// <param name="prop">被移除的道具卡</param>
    /// <param name="isDestroy">是否为强制移除（无视使用次数）</param>
    public static void RemoveProp(GameObject prop, bool isDestroy = false)
    {
        PropManager.RemoveProp(prop, isDestroy);
    }

    /// <summary>
    /// 使用一张道具卡
    /// </summary>
    /// <param name="prop">被使用的道具卡</param>
    public static void ConsumeProp(GameObject prop)
    {
        PropManager.ConsumeProp(prop);
    }

    /// <summary>
    /// 选择一张道具卡
    /// </summary>
    /// <param name="prop">被选择的道具卡</param>
    public static void SelectProp(GameObject prop)
    {
        PropManager.SelectProp(prop);
    }

    /// <summary>
    /// 取消一张道具卡的选择
    /// </summary>
    /// <param name="prop">被取消选择的道具卡</param>
    public static void UnselectProp(GameObject prop)
    {
        PropManager.UnselectProp(prop);
    }

    #endregion
}