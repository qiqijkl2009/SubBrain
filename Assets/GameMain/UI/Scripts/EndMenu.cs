using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndMenu : MonoBehaviour
{
    [SerializeField] private Image FadingMask1;
    [SerializeField] private Image FadingMask2;
    [SerializeField] private Button BackBtn;

    // Start is called before the first frame update
    void Start()
    {
        BackBtn.onClick.AddListener(GoToMenu);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartFading()
    {
        FadingMask1.gameObject.SetActive(true);
        FadingMask1.color = Color.clear;
        FadingMask1.DOColor(Color.black, 5f);
    }

    void GoToMenu()
    {
        FadingMask2.gameObject.SetActive(true);
        FadingMask2.transform.SetAsLastSibling();
        FadingMask2.color = Color.clear;
        FadingMask2.DOColor(Color.black, 3f).OnComplete(() => 
        { 
        SceneManager.LoadScene("Menu");
        });
    }
}
