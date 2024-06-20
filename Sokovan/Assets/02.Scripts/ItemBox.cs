using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
    private Renderer myRenderer;

    public Color touchColor;
    private Color originalColor;

    public bool isOveraped = false;

    void Start()
    {
        myRenderer = GetComponent<Renderer>();
        originalColor = myRenderer.material.color;
    }

    void Update()
    {
        
    }


    // 트리거인 콜라이더와 충돌할때 자동으로 실행
    // Enter 충돌을 한 순간
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "EndPoint")
        {
            isOveraped = true;
            myRenderer.material.color = touchColor;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "EndPoint")
        {
            isOveraped = false;
            myRenderer.material.color = originalColor;
        }
    }

    // Stay 충돌하고 있는 혹은 붙어 있는 '동안'
     void OnTriggerStay(Collider other)
     {
        if (other.tag == "EndPoint")
        {
            isOveraped = true;
            myRenderer.material.color = touchColor;
        }
     }


    // 일반 콜라이더와 충돌했을때 자동으로 실행
    void OnCollisionEnter(Collision collision)
    {
        
    }

}
