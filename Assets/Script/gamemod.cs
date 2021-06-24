using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamemod : MonoBehaviour
{
    public static bool gamepause;
    public GameObject repeat;
     void Update()
    {
        if (PlayerPrefs.GetInt("lvl") > 2)
        {
            gamepause = true;
            repeat.SetActive(true);
        }
    }
}
    
