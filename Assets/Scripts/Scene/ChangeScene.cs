using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public string nextSceneName; // 다음 씬의 이름
    int clickCount = 0; // 클릭 횟수

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // 마우스 왼쪽 버튼이 눌렸으면
        {
            clickCount++; // 클릭 횟수 증가
            if (clickCount == 4) // 클릭 횟수가 3이면
            {
                SceneManager.LoadScene(nextSceneName); // 다음 씬으로 이동
            }
        }
    }
}