using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public string nextSceneName; // 다음 씬의 이름
    public Image[] images; // 체크할 이미지들
    public Button nextButton; // 다음 씬으로 이동할 버튼

    void Start()
    {
        nextButton.onClick.AddListener(GoToNextSceneIfReady);
    }

    void OnEnable()
    {
        foreach (Image image in images)
        {
            image.enabled = true;
        }
    }

    void OnDisable()
    {
        foreach (Image image in images)
        {
            image.enabled = false;
        }
    }

    void GoToNextSceneIfReady()
    {
        // 모든 이미지가 활성화되었다면 다음 씬으로 이동합니다.
        foreach (Image image in images)
        {
            if (!image.enabled)
            {
                // 하나라도 비활성화된 이미지가 있다면 함수를 종료합니다.
                return;
            }
        }

        // 모든 이미지가 활성화되었다면 다음 씬으로 이동합니다.
        SceneManager.LoadScene(nextSceneName);
    }
}
