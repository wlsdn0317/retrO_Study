using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloFuncthion : MonoBehaviour
{
    void Start()
    {
        float sizeOfCircle = 30f;

        float radius = GetRadius(sizeOfCircle);

        Debug.Log("원의 넓이는 " + sizeOfCircle + "원의 반지름은 " + radius);
    }

    // Scope 
    float GetRadius(float size)
    {
        float pi = 3.14f;

        float tmp = size/pi;

        //Mathf.Sqrt(squre route)
        float radius = Mathf.Sqrt(tmp);

        return radius;
    }




}
