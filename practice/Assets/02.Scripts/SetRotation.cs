using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetRotation : MonoBehaviour
{
    public Transform targetTransform;


    void Start()
    {
        //target의로의 방향과 거리
        Vector3 direction = targetTransform.position - transform.position;


        Quaternion newRotation = Quaternion.Euler(new Vector3(30, 45, 60));

        //LookRotation(방향) 해당방향으로 바라보게 돌림
        Quaternion targetRotation = Quaternion.LookRotation(direction);

        transform.rotation = targetRotation;
    }

  
}
