using System.Collections;
using UnityEngine;

public class laberActive : MonoBehaviour
{
    public GameObject objectToActivate; // 활성화할 오브젝트
    

    public void OnButtonClick()
    {
        objectToActivate.SetActive(true); // 오브젝트 활성화

    }

}