using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ResetGame : MonoBehaviour
{
    public Button resetButton; // 초기화 버튼

    void Start()
    {
        // 초기화 버튼에 클릭 이벤트를 추가합니다.
        resetButton.onClick.AddListener(ResetGameData);
    }

    public void ResetGameData()
    {
        // 게임 데이터를 초기화합니다.
        PlayerPrefs.DeleteAll();

        // 첫 번째 씬을 로드하여 게임을 처음부터 다시 시작합니다.
        SceneManager.LoadScene(0);
    }
}