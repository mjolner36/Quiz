using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public  int level;
    public GameObject cubePref;

    void Awake()
    {
            if ((PlayerPrefs.GetInt("lvl") != 0) && (PlayerPrefs.GetInt("lvl") != 1) && (PlayerPrefs.GetInt("lvl") != 2)) PlayerPrefs.SetInt("lvl", 0);
            level = PlayerPrefs.GetInt("lvl");
            CreatLevel();
           
        
        
        

        
       
    }


    void CreatLevel()
    {
        for (int i = 0; i < 3; i++)
            for (int k = 0; k <= level; k++)
            {
                SpawnCube(i, k);
            }
    }

    void SpawnCube(int x, int y)
    {
        GameObject tmpCube = Instantiate(cubePref);
        float sprSizeX = tmpCube.GetComponent<SpriteRenderer>().bounds.size.x;
        float sprSizeY = tmpCube.GetComponent<SpriteRenderer>().bounds.size.y;
        if (level == 0 || level == 2)
            tmpCube.transform.position = new Vector3(sprSizeX * (-1 + x), (sprSizeY / 2) * level * (-1 + y));
        else if (level == 1)
        {
            int num;
            if (y == 0) num = 1;
            else num = -1;
            tmpCube.transform.position = new Vector3(sprSizeX * (-1 + x), (sprSizeY / 2) * level * num);

        }
      
    }

}