using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hackActive : MonoBehaviour
{
    public GameObject hack;
    int clickCount = 0;



    public void OnButtonclick()
    {

        {
            clickCount++;
            if (clickCount == 1)
            {
                hack.SetActive(true);

            }
        }
    }
}
