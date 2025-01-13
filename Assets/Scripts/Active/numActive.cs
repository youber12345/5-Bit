using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class numActive : MonoBehaviour
{
    public GameObject targetObject;

    int clickCount = 0;

    public float speed = 0.1f; // 오브젝트의 크기를 줄이는 속도입니다.

    void Update()
    {
        if (clickCount >= 10 && targetObject.transform.localScale.y > 0)
        {
            Vector3 scale = targetObject.transform.localScale; // 오브젝트의 scale 값을 가져옴
            scale.y -= speed * Time.deltaTime; // y scale 값을 감소시킴
            if (scale.y < 0) // y scale 값이 0보다 작으면
            {
                scale.y = 0; // y scale 값을 0으로 설정
                targetObject.SetActive(false); // targetObject를 비활성화함
            }
            targetObject.transform.localScale = scale; // 오브젝트의 scale 값을 변경함
        }
    }

    public void OnButtonclick()
    {
        clickCount++;
    }
}
