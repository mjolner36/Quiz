
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
        
        
            if ((ItWas[index] == true) && (NoRepeatsrt.norepeat[0] != index) && (NoRepeatsrt.norepeat[1] != index) && (NoRepeatsrt.norepeat[2] != index))
            {


                if (NoRepeatsrt.norepeat[0] == -1)
                {
                    isTrue = index;
                    Debug.Log(isTrue);
                    NoRepeatsrt.norepeat[0] = index;
                }
                    else if (NoRepeatsrt.norepeat[1] == -1)
                {
                    isTrue = index;
                    Debug.Log(isTrue);
                    NoRepeatsrt.norepeat[1] = index;
                }
                       else
                       {
                            isTrue = index;
                            Debug.Log(isTrue);
                            NoRepeatsrt.norepeat[2] = index;
                        }
                                 
            
               
                
                
           
                
               
            }
            else goto m1;
        

           
       
    }

            
  
}
