using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivateObject11 : MonoBehaviour
{
    public GameObject targetObject;
    public GameObject targetObject1; // 인스펙터에서 활성화할 오브젝트를 지정합니다.
    public string correctText = "2077"; // 이 텍스트를 맞추면 오브젝트가 활성화됩니다.
    public Text userText; // 인스펙터에서 사용자의 입력을 받을 텍스트 필드를 지정합니다.
    public float speed = 0.1f; // 오브젝트의 크기를 줄이는 속도입니다.

    private bool isShrinking = false; // 오브젝트가 줄어들고 있는지 여부를 나타냅니다.

    void Update()
    {
        if (isShrinking && targetObject1.transform.localScale.y > 0)
        {
            Vector3 scale = targetObject1.transform.localScale; // 오브젝트의 scale 값을 가져옴
            scale.y -= speed * Time.deltaTime; // y scale 값을 감소시킴
            if (scale.y < 0) // y scale 값이 0보다 작으면
            {
                scale.y = 0; // y scale 값을 0으로 설정
                targetObject1.SetActive(false); // targetObject1을 비활성화함
            }
            targetObject1.transform.localScale = scale; // 오브젝트의 scale 값을 변경함
        }
    }

    public void CheckText()
    {
        if (userText.text == correctText)
        {
            targetObject.SetActive(true);
            isShrinking = true; // 사용자가 정답을 입력하면 오브젝트를 줄입니다.
        }
    }
}
