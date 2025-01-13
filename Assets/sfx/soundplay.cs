using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundplay : MonoBehaviour
{
    public AudioSource audioSource;
    


    public void OnButtonclick()
    {
        audioSource.gameObject.SetActive(true);

       

        audioSource.Play();
    }
        
}
