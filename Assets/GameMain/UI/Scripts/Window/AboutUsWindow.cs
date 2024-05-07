using JKFrame;
using UnityEngine;
using UnityEngine.UI;

[UIWindowData(typeof(AboutUsWindow), true, GameConstant.UIWindow.ABOUT_US_WINDOW, 0)]
public class AboutUsWindow : UI_WindowBase
{
    [SerializeField] private Button _closeButton;

    public override void Init()
    {
        _closeButton.onClick.AddListener(CloseTheWindow);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            CloseTheWindow();
        }
    }

    private void CloseTheWindow()
    {
        UISystem.Close<AboutUsWindow>();
    }
}