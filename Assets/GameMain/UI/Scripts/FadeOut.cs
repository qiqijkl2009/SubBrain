using DG.Tweening;
using UnityEngine;
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
