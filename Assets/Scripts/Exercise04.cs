using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise04 : MonoBehaviour
{
    public int left;
    public int right;
    private int i;
    void Start()
    {
        left = i;
        while (i < right)
        {
            if (i % 5 == 0)
            {
                Debug.Log(i);
            }
            i++;
        }
    }
}
