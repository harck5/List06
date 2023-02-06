using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise03 : MonoBehaviour
{
    public int value;
    void Start()
    {
        for (int i = value; i >= 0; i--)
        {
            Debug.Log(i);
        }
    }
}
