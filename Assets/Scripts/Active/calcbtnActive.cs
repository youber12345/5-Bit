using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class calbtnActive : MonoBehaviour
{

    public GameObject calbtn;
    int clickCount = 0;


    public void OnButtonclick()
    {

        {
            clickCount++;
            if (clickCount == 10)
            {
                calbtn.SetActive(true);

            }
        }
    }
}
