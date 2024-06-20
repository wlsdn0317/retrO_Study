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


    // Ʈ������ �ݶ��̴��� �浹�Ҷ� �ڵ����� ����
    // Enter �浹�� �� ����
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

    // Stay �浹�ϰ� �ִ� Ȥ�� �پ� �ִ� '����'
     void OnTriggerStay(Collider other)
     {
        if (other.tag == "EndPoint")
        {
            isOveraped = true;
            myRenderer.material.color = touchColor;
        }
     }


    // �Ϲ� �ݶ��̴��� �浹������ �ڵ����� ����
    void OnCollisionEnter(Collision collision)
    {
        
    }

}
