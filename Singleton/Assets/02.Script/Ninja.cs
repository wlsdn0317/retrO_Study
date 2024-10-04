using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ninja : MonoBehaviour
{
    public static Ninja ninjaKing;

    public string ninjaName;
    public bool isKing;

    private void Start()
    {
        if (isKing)
        {
            ninjaKing = this;
        }
    }

    private void Update()
    {
        Debug.Log("My name: " + ninjaName + ", Ninja King is" + ninjaKing);
    }

}
