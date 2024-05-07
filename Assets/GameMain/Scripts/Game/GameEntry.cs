using JKFrame;
using UnityEngine;

public class GameEntry : MonoBehaviour
{
    private void Start()
    {
        if (SaveSystem.GetSaveItem(0) == null) SaveSystem.CreateSaveItem();
        
        InitSystem();
        InitScene();
    }

    private static void InitSystem()
    {
        CardSystem.Init();
    }

    private static void InitScene()
    {
        SceneSystem.LoadScene(GameConstant.Scene.MAIN_MENU);
        UISystem.Show<MainMenuWindow>();
        AudioSystem.PlayBGAudio(R.Audio.MainMenu);
    }
}