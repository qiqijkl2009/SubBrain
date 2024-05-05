using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using DG.Tweening;

public class StartMenu : MonoBehaviour
{
    [SerializeField] private Button StartBtn;
    [SerializeField] private Button AboutBtn;
    [SerializeField] private Button ExitBtn;

    [SerializeField] private GameObject TeamPanel;
    [SerializeField] private Button CloseAbout;

    [SerializeField] private Image FadingMask;

    // Start is called before the first frame update
    void Start()
    {
        FadingMask.gameObject.SetActive(false);
        FadingMask.color = Color.clear;

        StartBtn.onClick.AddListener(GotoScene);

        AboutBtn.onClick.AddListener(delegate()
        {
            TeamPanel.SetActive(true);
        });
        CloseAbout.onClick.AddListener(delegate ()
        {
            TeamPanel.SetActive(false);
        });

        ExitBtn.onClick.AddListener(QuitGame);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!TeamPanel.activeInHierarchy)
            {
                 return;
            }
            TeamPanel.SetActive(false);
        }
    }

    void GotoScene()
    {
        FadingMask.gameObject.SetActive(true);
        FadingMask.DOColor(Color.black, 2f).OnComplete(() =>
        {
            SceneManager.LoadScene("UIPlayground");
        });
    }

    void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
