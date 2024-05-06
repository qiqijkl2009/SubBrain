using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FadeOut : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FadingOut()
    {
        gameObject.SetActive(true);
        GetComponent<Image>().color = Color.clear;
        GetComponent<Image>().DOColor(Color.black, 5f);
    }
}
