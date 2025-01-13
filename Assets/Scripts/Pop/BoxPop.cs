using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxPop : MonoBehaviour
{ 

    public GameObject BoxPoping;
    public float speed = 1.0f;
    private Vector3 targetPosition;

    void Start()
    {
        targetPosition = BoxPoping.transform.position;
        BoxPoping.transform.position = new Vector3(BoxPoping.transform.position.x + 10, BoxPoping.transform.position.y, BoxPoping.transform.position.z);
    }

    void Update()
    {
        BoxPoping.transform.position = Vector3.Lerp(BoxPoping.transform.position, targetPosition, Time.deltaTime * speed);
    }

}
