using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blackpanel : MonoBehaviour
{
    public GameObject blackPanel;
    public GameObject repeat;
    void Update()
    {
        if (gamemod.gamepause == true) StartCoroutine(BlackPanelShow());
    }
    IEnumerator BlackPanelShow ()
    {
        yield return new WaitForSeconds(1);
        blackPanel.SetActive(true);
        repeat.SetActive(true);
    }
}
