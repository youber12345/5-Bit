using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laberPop : MonoBehaviour
{
    public GameObject LaberPoping;
    public float speed = 1.0f;
    private Vector3 targetPosition;

    void Start()
    {
        targetPosition = LaberPoping.transform.position;
        LaberPoping.transform.position = new Vector3(LaberPoping.transform.position.x, LaberPoping.transform.position.y - 10, LaberPoping.transform.position.z);
    }

    void Update()
    {
        LaberPoping.transform.position = Vector3.Lerp(LaberPoping.transform.position, targetPosition, Time.deltaTime * speed);
    }
}