using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fade : MonoBehaviour
{
    public Image fadeImage;

    void FadeIn()
    {
        Color startColor = fadeImage.color;
        
        for(int i = 0; i < 100; i++)
        {
            startColor.a = 1.0f;
        }

    }

    
}
