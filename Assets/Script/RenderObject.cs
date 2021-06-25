
using UnityEngine;


public class RenderObject : MonoBehaviour
{
    
    void Start()
    
    {
        int index;

        do
        {
            index = Random.Range(0, GameObject.Find("Main Camera").GetComponent<Generation>().objects.Count);
            if (GameObject.Find("Main Camera").GetComponent<Generation>().ItWas[index] != true)
            {
                GameObject.Find("Main Camera").GetComponent<Generation>().ItWas[index] = true;
                break;

            }
            
        }
        while (true);


       Sprite card = GameObject.Find("Main Camera").GetComponent<Generation>().objects[index];
        gameObject.GetComponent<SpriteRenderer>().sprite = card;
    }
    
}
