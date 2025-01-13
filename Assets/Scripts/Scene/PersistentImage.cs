using UnityEngine;
using UnityEngine.UI;

public class PersistentImage : MonoBehaviour
{
    public static bool IsImageActive; // 이미지의 활성화 상태를 저장할 정적 변수

    private Image image; // 현재 게임 오브젝트의 이미지 컴포넌트

    private void Awake()
    {
        image = GetComponent<Image>(); // 이미지 컴포넌트 가져오기

        if (IsImageActive) // 정적 변수에 저장된 활성화 상태가 있다면
        {
            image.gameObject.SetActive(true); // 이미지의 게임 오브젝트를 활성화
        }

        DontDestroyOnLoad(gameObject); // 씬이 바뀌어도 게임 오브젝트가 파괴되지 않도록 설정
    }

    private void OnDestroy()
    {
        IsImageActive = image.gameObject.activeSelf; // 게임 오브젝트가 파괴될 때 이미지의 활성화 상태를 정적 변수에 저장
    }
}