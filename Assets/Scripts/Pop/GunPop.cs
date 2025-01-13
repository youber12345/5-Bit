using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunPop : MonoBehaviour
{

    public GameObject GunPoping;
    public float speed = 1.0f;
    private Vector3 targetPosition;

    void Start()
    {
        targetPosition = GunPoping.transform.position;
        GunPoping.transform.position = new Vector3(GunPoping.transform.position.x + 10, GunPoping.transform.position.y, GunPoping.transform.position.z);
    }

    void Update()
    {
        GunPoping.transform.position = Vector3.Lerp(GunPoping.transform.position, targetPosition, Time.deltaTime * speed);
    }

}
