using DG.Tweening;
using JKFrame;
using UnityEngine;
using UnityEngine.UI;

[UIWindowData(typeof(MainMenuWindow), true, GameConstant.UIWindow.MAIN_MENU_WINDOW, 0)]
public class MainMenuWindow : UI_WindowBase
{
    [SerializeField] private Button _startButton;
    [SerializeField] private Button _aboutUsButton;
    [SerializeField] private Button _exitButton;

    public override void Init()
    {
        _startButton.onClick.AddListener(GoToGameScene);
        _aboutUsButton.onClick.AddListener(OpenAboutUsWindow);
        _exitButton.onClick.AddListener(QuitGame);
    }

    private void GoToGameScene()
    {
        var fadeWindow = UISystem.Show<FadeWindow>();
        fadeWindow.FadeOut(2f, () =>
        {
            SceneSystem.LoadScene(GameConstant.Scene.GAME);
            UISystem.Close<MainMenuWindow>();
            fadeWindow.FadeIn(2f, UISystem.Close<FadeWindow>);
        });
    }

    private void OpenAboutUsWindow()
    {
        UISystem.Show<AboutUsWindow>();
    }

    private void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}