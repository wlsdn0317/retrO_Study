using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : MonoBehaviour
{
    public string nickName;

    public float weight;

    //���� ���� ��
    public static int count = 0;

    private void Awake()
    {
        count = count + 1;
    }

    private void Start()
    {
        Bark();
    }

    public void Bark()
    {
        Debug.Log("��� ������ ��: "  + count);
        Debug.Log(nickName + ": Bark!");
    }

    public static void ShowAnimalType()
    {
        Debug.Log("�̰��� ���Դϴ�.");
    }
}
