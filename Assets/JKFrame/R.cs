using JKFrame;
 using UnityEngine;

namespace R
{
 
    public static class DefaultLocalGroup
    {

    } 
    public static class Texture
    {

    } 
    public static class Test
    {
 
        public static GameObject TestPropCard { get => ResSystem.LoadAsset<GameObject>("TestPropCard"); }  
        public static GameObject TestPropCard_GameObject(Transform parent = null,string keyName=null,bool autoRelease = true)
        {
            return ResSystem.InstantiateGameObject("TestPropCard", parent, keyName,autoRelease);
        }
    }
}