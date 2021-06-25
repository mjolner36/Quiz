using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoRepeatsrt : MonoBehaviour
{
    static public int[] norepeat = new int[3];
    void Awake()
    {
        for (int i = 0; i < 3; i++){
            norepeat[i] = -1;
        }
    
    }

}
