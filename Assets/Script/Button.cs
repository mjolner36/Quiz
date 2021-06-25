
using UnityEngine;


public class Button : MonoBehaviour
{
    
    private int levelToLoad;
     public static bool isloadscene;


    private void OnMouseDown()
    {   
        PlayerPrefs.SetInt("lvl", 0);
        gamemod.gamepause = false;
        isloadscene = true;
        
    }


    
}
