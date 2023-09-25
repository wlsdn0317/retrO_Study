using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloMath : MonoBehaviour
{
    void Start()
    {
        /*
        int a =5;

        int b = 7;

        int sum = a+b;

        Debug.Log(sum);

        sum = a-b;

        Debug.Log(sum);

        Debug.Log(a*b);

        Debug.Log(a/b);

        Debug.Log(b/a);

        Debug.Log(a%b);

        Debug.Log(b%a);
        */

        /*
        int i =0;

        i = i+1;    

        Debug.Log(i);

        i++;

        Debug.Log(i);

        i = i-1;

        Debug.Log(i);

        i--;

        Debug.Log(i);

        ++i;

        Debug.Log(i);
        */

        int i = 0;

        //0
        Debug.Log(i++);
        //1
        Debug.Log(i);
        //2
        Debug.Log(++i);
        //2
        Debug.Log(i);

        //복합 연산자 (short cut)
        int j = 5;
        j = j+5;
        j += 5;
        j -= 5;
        j *=5;
        j /= 5;
        j %= 5;


    }

   
}
