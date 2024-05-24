using System;
using DG.Tweening;
using JKFrame;
using UnityEngine;
using UnityEngine.UI;

public class GameOverMask : MonoBehaviour
{
    [SerializeField] private Image _backGround;
    [SerializeField] private Button _backButton;

    private void Start()
    {
        _backButton.onClick.AddListener(GoToMainMenu);
    }

    public void ShowMask()
    {
        _backGround.DOColor(Color.black, 3f).OnComplete(() => _backButton.gameObject.SetActive(true));
    }

    private static void GoToMainMenu()
    {
        DOTween.KillAll();
        AudioSystem.PlayOneShot(AudioExtension.RandomUIClick());
        var fadeWindow = UISystem.Show<FadeWindow>();
        fadeWindow.FadeOut(2f, () =>
        {
            SceneSystem.LoadScene(GameConstant.Scene.MAIN_MENU);
            UISystem.Show<MainMenuWindow>();
            fadeWindow.FadeIn(2f, UISystem.Close<FadeWindow>);
        });
    }
}