using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Activesun : MonoBehaviour
{
    public GameObject sun; 

    // Update is called once per frame
    public void OnButtonClick()
    {
        sun.SetActive(true);
    }
}
