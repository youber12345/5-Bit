using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F5))
        {
            // "NextScene"이라는 이름의 씬으로 전환합니다.
            SceneManager.LoadScene("lastScene");
        }
    }
}
