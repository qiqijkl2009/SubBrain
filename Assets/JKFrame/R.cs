using JKFrame;
 using UnityEngine;

namespace R
{
 
    public static class DefaultLocalGroup
    {

    } 
    public static class Texture
    {
 
        public static Texture2D Event03 { get => ResSystem.LoadAsset<Texture2D>("Event03"); }  
        public static Sprite Event03_Event03 { get => ResSystem.LoadAsset<Sprite>("Event03[Event03]"); } 
        public static Texture2D Event02 { get => ResSystem.LoadAsset<Texture2D>("Event02"); }  
        public static Sprite Event02_Event02 { get => ResSystem.LoadAsset<Sprite>("Event02[Event02]"); } 
        public static Texture2D Event01 { get => ResSystem.LoadAsset<Texture2D>("Event01"); }  
        public static Sprite Event01_Event01 { get => ResSystem.LoadAsset<Sprite>("Event01[Event01]"); } 
        public static Texture2D Event04 { get => ResSystem.LoadAsset<Texture2D>("Event04"); }  
        public static Sprite Event04_Event04 { get => ResSystem.LoadAsset<Sprite>("Event04[Event04]"); } 
        public static Texture2D Event05 { get => ResSystem.LoadAsset<Texture2D>("Event05"); }  
        public static Sprite Event05_Event05 { get => ResSystem.LoadAsset<Sprite>("Event05[Event05]"); } 
        public static Texture2D Event06 { get => ResSystem.LoadAsset<Texture2D>("Event06"); }  
        public static Sprite Event06_Event06 { get => ResSystem.LoadAsset<Sprite>("Event06[Event06]"); }
    } 
    public static class Test
    {

    } 
    public static class Card
    {
 
        public static GameObject ActionCard { get => ResSystem.LoadAsset<GameObject>("ActionCard"); }  
        public static GameObject ActionCard_GameObject(Transform parent = null,string keyName=null,bool autoRelease = true)
        {
            return ResSystem.InstantiateGameObject("ActionCard", parent, keyName,autoRelease);
        } 
        public static GameObject PropCard { get => ResSystem.LoadAsset<GameObject>("PropCard"); }  
        public static GameObject PropCard_GameObject(Transform parent = null,string keyName=null,bool autoRelease = true)
        {
            return ResSystem.InstantiateGameObject("PropCard", parent, keyName,autoRelease);
        }
    }
}