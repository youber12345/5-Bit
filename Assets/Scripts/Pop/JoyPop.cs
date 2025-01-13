using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoyPop : MonoBehaviour
{
    public GameObject Joy;
    public int clickCount = 0;

    void Start()
    {
        Joy.SetActive(false);
    }

    public void OnButtonClick()
    {
        clickCount++;
        if (clickCount == 15)
        {
            Joy.SetActive(true);
            Instantiate(Joy, new Vector3(0, 0, 0), Quaternion.identity);
            clickCount = 0;
        }
    }
}