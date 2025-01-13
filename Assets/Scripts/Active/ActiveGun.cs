using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveGun : MonoBehaviour
{

    public GameObject gun;
    int clickCount = 0;

    
    public void OnButtonclick()
    {
        
        {
            clickCount++;
            if (clickCount == 5)
            {
                gun.SetActive(true);
                
            }
        }
    }
}
