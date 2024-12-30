using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloCoroutine : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //""으로 코루틴을 사용하면 StopCoroutine사용 가능
        StartCoroutine("HelloUnity");
        StartCoroutine("HiCSharp");
        Debug.Log("End");
        

    }

    void Update(){
        if(Input.GetMouseButtonDown(0)){
            StopCoroutine("HelloUnity");
        }
    }

    IEnumerator HelloUnity(){
        Debug.Log("Hello");
        yield return new WaitForSeconds(3f);
        Debug.Log("Unity");
    }

    IEnumerator HiCSharp(){
        Debug.Log("Hi");

        yield return new WaitForSeconds(5f);
        Debug.Log("CSharp");
    }
}
