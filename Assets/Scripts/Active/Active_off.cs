using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Active_off : MonoBehaviour
{
  
    public GameObject Target1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Target1.SetActive(false);
        }
        
    }
}
