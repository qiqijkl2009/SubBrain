using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Image FadingMask = GetComponent<Image>();
        gameObject.SetActive(true);
        FadingMask.color = Color.black;
        FadingMask.DOColor(Color.clear, 2f).OnComplete(() =>
        {
            gameObject.SetActive(false);
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
