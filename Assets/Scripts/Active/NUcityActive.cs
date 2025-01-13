using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NUcityActive : MonoBehaviour
{

    public GameObject Nucity;
    int clickCount = 0;


    public void OnButtonclick()
    {

        {
            clickCount++;
            if (clickCount == 35)
            {
                Nucity.SetActive(true);

            }
        }
    }
}
