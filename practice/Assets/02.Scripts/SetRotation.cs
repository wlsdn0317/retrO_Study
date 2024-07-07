using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetRotation : MonoBehaviour
{
    public Transform targetTransform;


    void Start()
    {
        //target�Ƿ��� ����� �Ÿ�
        Vector3 direction = targetTransform.position - transform.position;


        Quaternion newRotation = Quaternion.Euler(new Vector3(30, 45, 60));

        //LookRotation(����) �ش�������� �ٶ󺸰� ����
        Quaternion targetRotation = Quaternion.LookRotation(direction);

        transform.rotation = targetRotation;
    }

  
}
