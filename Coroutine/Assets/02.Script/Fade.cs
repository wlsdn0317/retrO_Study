using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fade : MonoBehaviour
{
    public Image fadeImage;

    void Start()
    {
        //성능이 좋지만 인위적으로 멈추진 못함
        StartCoroutine(FadeIn());
        //인위적으로 멈출수 있음 ""로 입력하면
        //StartCoroutine("FadeIn"); 
    }

    IEnumerator FadeIn()
    {
        Color startColor = fadeImage.color;
        
        for(int i = 0; i < 100; i++)
        {
            startColor.a = startColor.a - 0.01f;
            fadeImage.color = startColor;
            yield return new WaitForSeconds(0.01f);
        }

    }

    
}
