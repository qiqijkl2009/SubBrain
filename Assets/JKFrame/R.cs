using JKFrame;
 using UnityEngine;

namespace R
{
 
    public static class DefaultLocalGroup
    {

    } 
    public static class Texture
    {
 
        public static Texture2D TestImage1 { get => ResSystem.LoadAsset<Texture2D>("TestImage1"); }  
        public static Sprite TestImage1_TestImage1 { get => ResSystem.LoadAsset<Sprite>("TestImage1[TestImage1]"); } 
        public static Texture2D TestImage2 { get => ResSystem.LoadAsset<Texture2D>("TestImage2"); }  
        public static Sprite TestImage2_TestImage2 { get => ResSystem.LoadAsset<Sprite>("TestImage2[TestImage2]"); } 
        public static Texture2D TestImage3 { get => ResSystem.LoadAsset<Texture2D>("TestImage3"); }  
        public static Sprite TestImage3_TestImage3 { get => ResSystem.LoadAsset<Sprite>("TestImage3[TestImage3]"); }
    } 
    public static class Test
    {
 
        public static GameObject TestPropCard { get => ResSystem.LoadAsset<GameObject>("TestPropCard"); }  
        public static GameObject TestPropCard_GameObject(Transform parent = null,string keyName=null,bool autoRelease = true)
        {
            return ResSystem.InstantiateGameObject("TestPropCard", parent, keyName,autoRelease);
        }
    } 
    public static class Card
    {
 
        public static GameObject ActionCard { get => ResSystem.LoadAsset<GameObject>("ActionCard"); }  
        public static GameObject ActionCard_GameObject(Transform parent = null,string keyName=null,bool autoRelease = true)
        {
            return ResSystem.InstantiateGameObject("ActionCard", parent, keyName,autoRelease);
        }
    }
}