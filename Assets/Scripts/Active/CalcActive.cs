using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalcActive : MonoBehaviour
{
    public GameObject calc;
    int clickCount = 0;



    public void OnButtonclick()
    {

        {
            clickCount++;
            if (clickCount == 20)
            {
                calc.SetActive(true);

            }
        }
    }
}
