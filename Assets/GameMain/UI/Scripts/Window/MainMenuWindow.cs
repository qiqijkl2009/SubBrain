using DG.Tweening;
using JKFrame;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

[UIWindowData(typeof(MainMenuWindow), true, GameConstant.UIWindow.MAIN_MENU_WINDOW, 0)]
public class MainMenuWindow : UI_WindowBase
{
    [SerializeField] private Button _startButton;
    [SerializeField] private Button _aboutUsButton;
    [SerializeField] private Button _exitButton;

    [SerializeField] private Image _fadingMask;

    public override void Init()
    {
        _fadingMask.gameObject.SetActive(false);
        _fadingMask.color = Color.clear;

        _startButton.onClick.AddListener(GoToGameScene);
        _aboutUsButton.onClick.AddListener(OpenAboutUsWindow);
        _exitButton.onClick.AddListener(QuitGame);
    }

    private void GoToGameScene()
    {
        _fadingMask.gameObject.SetActive(true);
        _fadingMask.DOColor(Color.black, 2f).OnComplete(() => { SceneSystem.LoadScene(GameConstant.Scene.GAME); });
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