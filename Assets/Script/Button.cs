using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{

    
    private void OnMouseDown()
    {
        PlayerPrefs.SetInt("lvl", 0);
        SceneManager.LoadScene("Game");
        gamemod.gamepause = false;
    }
}
