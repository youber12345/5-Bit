using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveBox : MonoBehaviour
{

    public GameObject Box;
    int clickCount = 0;
    


    public void OnButtonclick()
    {

        {
            clickCount++;
            if (clickCount == 5)
            {
                Box.SetActive(true);

            }
        }
    }
   
}
