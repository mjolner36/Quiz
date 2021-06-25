using System.Collections;

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
            StartCoroutine(RepeatShow());
        }
    }

    IEnumerator RepeatShow()
    {
        yield return new WaitForSeconds(1);                
        repeat.SetActive(true);
    }
}
    
