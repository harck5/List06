using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise05 : MonoBehaviour
{
    private int num;
    public int[] array;
    void Start()
    {
        foreach (int i in array)
        {
            num = num + i;
        }
        Debug.Log($"{array[0]} + {array[1]} + {array[2]} + {array[3]} + {array[4]} = {num}");
    }
}
