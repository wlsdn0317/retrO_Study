using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public delegate [반환형] [이름](매개변수)
public delegate void MyDelegate();

public class DelegateTest : MonoBehaviour
{
    //delegate를 event 한정자로 수식해서 만든다.
    public event MyDelegate myEvent;

}
