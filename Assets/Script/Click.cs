using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class Click : MonoBehaviour
{
    public GameObject effect;
    public GameObject childUI;
    public float anumDuration;
    

    private void Start()
    {   if (PlayerPrefs.GetInt("lvl")==0)
        bounce(this.gameObject);
    }
    private void OnMouseDown()
    {

        if (gamemod.gamepause != true)
        {
            if (childUI.GetComponent<SpriteRenderer>().sprite.name == GameObject.Find("Main Camera").GetComponent<Generation>().nameObjects[Generation.isTrue])
            {
                Debug.Log("win");
                Instantiate(effect, transform.position, Quaternion.identity);
                PlayerPrefs.SetInt("lvl", GameObject.Find("Main Camera").GetComponent<LevelManager>().level + 1);
                if (PlayerPrefs.GetInt("lvl") < 3) StartCoroutine(LoadLevel());
                bounce(childUI);

            }
            else Wrongclick();
        }
    }

    public void Wrongclick()
    {
        transform.DOShakePosition(0.5f,0.5f,8,20,false,true);
    }

    IEnumerator LoadLevel()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Game");
    }

    public void bounce(GameObject tmp)
    {
        
        tmp.transform.DOScale(new Vector3 (0.2f,0.2f,0f), 0.5f);
        StartCoroutine(RepeatShow(tmp));
    }

    IEnumerator RepeatShow(GameObject tmp)
    {
        
        yield return new WaitForSeconds(0.2f);
        tmp.transform.DOScale(new Vector3(1f, 1f, 0f), 0.5f);

    }
}

