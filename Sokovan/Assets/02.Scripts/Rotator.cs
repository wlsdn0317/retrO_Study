using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    //Update�� �뷫 1�ʿ� 60��
    void Update()
    {
        // 1���� 60��
        transform.Rotate(60 * Time.deltaTime, 60*Time.deltaTime, 60 * Time.deltaTime);

        //Time.deltatime �� ȭ���� �ѹ� �����̴� �ð� = �� �������� �ð� 
        //ȭ���� 60�� �����̸� (�ʴ� 60������) 1/60
        //ȭ���� 200�� �����̸� (�ʴ� 200������) 1/200

    }

    //�ϵ� �� ���ǵ� - �����ڽ� �ܼ� / PC��
    //������ ��
}
