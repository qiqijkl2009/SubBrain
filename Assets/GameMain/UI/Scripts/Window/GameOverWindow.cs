using System;
using DG.Tweening;
using JKFrame;
using UnityEngine;
using UnityEngine.UI;

[UIWindowData(typeof(GameOverWindow), true, GameConstant.UIWindow.GAME_OVER_WINDOW, 0)]
public class GameOverWindow : UI_WindowBase
{
    [SerializeField] private Image _backGround;
    [SerializeField] private Button _backButton;

    public override void Init()
    {
        _backButton.onClick.AddListener(GoToMainMenu);
    }

    public override void OnShow()
    {
        _backGround.color = Color.clear;
        _backGround.DOColor(Color.black, 5f).OnComplete(() => _backButton.gameObject.SetActive(true));
    }

    public override void OnClose()
    {
        _backButton.gameObject.SetActive(false);
    }

    private void GoToMainMenu()
    {
        AudioSystem.PlayOneShot(AudioExtension.RandomUIClick());
        var fadeWindow = UISystem.Show<FadeWindow>();
        fadeWindow.FadeOut(2f, () =>
        {
            SceneSystem.LoadScene(GameConstant.Scene.MAIN_MENU);
            UISystem.Close<GameOverWindow>();
            UISystem.Show<MainMenuWindow>();
            fadeWindow.FadeIn(2f, UISystem.Close<FadeWindow>);
        });
    }
}