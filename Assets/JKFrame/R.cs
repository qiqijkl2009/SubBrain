 using JKFrame;
 using UnityEngine;

namespace R
{
 
    public static class DefaultLocalGroup
    {

    } 
    public static class Audio
    {
 
        public static AudioClip InGame { get => ResSystem.LoadAsset<AudioClip>("InGame"); } 
        public static AudioClip MainMenu { get => ResSystem.LoadAsset<AudioClip>("MainMenu"); }
    } 
    public static class Texture
    {
 
        public static Texture2D WakeUp { get => ResSystem.LoadAsset<Texture2D>("WakeUp"); }  
        public static Sprite WakeUp_WakeUp { get => ResSystem.LoadAsset<Sprite>("WakeUp[WakeUp]"); }
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
    public static class UIWindow
    {
 
        public static GameObject FadeInMask { get => ResSystem.LoadAsset<GameObject>("FadeInMask"); }  
        public static GameObject FadeInMask_GameObject(Transform parent = null,string keyName=null,bool autoRelease = true)
        {
            return ResSystem.InstantiateGameObject("FadeInMask", parent, keyName,autoRelease);
        } 
        public static GameObject FadeOutMask { get => ResSystem.LoadAsset<GameObject>("FadeOutMask"); }  
        public static GameObject FadeOutMask_GameObject(Transform parent = null,string keyName=null,bool autoRelease = true)
        {
            return ResSystem.InstantiateGameObject("FadeOutMask", parent, keyName,autoRelease);
        }
    } 
    public static class Test
    {

    }
}