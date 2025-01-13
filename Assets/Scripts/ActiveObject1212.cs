using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivateObject1212 : MonoBehaviour
{
    public GameObject targetObject;
    public string correctText = "666"; // 이 텍스트를 맞추면 오브젝트가 활성화됩니다.
    public Text userText; // 인스펙터에서 사용자의 입력을 받을 텍스트 필드를 지정합니다.


    public void CheckText()
    {
        if (userText.text == correctText)
        {
            targetObject.SetActive(true);
           
        }
    }
}
