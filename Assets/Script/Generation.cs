
using System.Collections.Generic;
using UnityEngine;

public class Generation : MonoBehaviour
{
    public List<Sprite> objects = new List<Sprite>();
    public List<string> nameObjects = new List<string>();
    public  List<bool> ItWas = new List<bool>(); // массив для проверки единственности 


    public static int isTrue;// верный ответ

    private void Start()
    {
         FindTrueAnswer();
        
    }


    void FindTrueAnswer()
    {
        int index;
    m1: index = Random.Range(0, objects.Count); //Получить случайное число (в диапазоне от 0 до List)                   
        if (ItWas[index] == true)
        {
            isTrue = index;
            Debug.Log(isTrue);
        }
        else goto m1;
        
       
    }
  
}
