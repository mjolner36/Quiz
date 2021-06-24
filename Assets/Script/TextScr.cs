using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScr : MonoBehaviour
{
    
    void Update()
    {      
        gameObject.GetComponent<Text>().text = "Find: " + GameObject.Find("Main Camera").GetComponent<Generation>().nameObjects[Generation.isTrue];
    }
}
