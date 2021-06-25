using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Fade : MonoBehaviour
{
    public Animator animator;
   
    private int levelToLoad;

    private void Update()
    {
       if (Button.isloadscene==true)
        {
            FadeToLevel();
        } 
    }
    
        
   


    public void FadeToLevel()
    {
        
        animator.SetTrigger("FadeOut");

    }
    public void OnFadeComplete()
    {
        SceneManager.LoadScene("Game");
        Button.isloadscene = false;

    }
}

