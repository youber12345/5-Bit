using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ResetScene : MonoBehaviour
{
    public Image image1;
    public Image image2;
    public Image image3;
    public Image image4;
    public Image image5;
    public Image image6;
    public Image image7;
    public Image image8;
    public Image image9;
    public Image imageback;
    public Texture2D defaultCursor;
    public Image fadeImage; // 페이드 인/아웃을 적용할 이미지
    public float fadeDuration = 1.0f; // 페이드 인/아웃 지속 시간
    bool isFading = false; // 페이드 인/아웃 중인지 여부

    void Start()
    {
        // 씬이 로드될 때 이미지의 활성화 상태를 PlayerPrefs에서 불러옵니다.
        image1.gameObject.SetActive(PlayerPrefs.GetInt("Image1Active", 0) == 1);
        image2.gameObject.SetActive(PlayerPrefs.GetInt("Image2Active", 0) == 1);
        image3.gameObject.SetActive(PlayerPrefs.GetInt("Image3Active", 0) == 1);
        image4.gameObject.SetActive(PlayerPrefs.GetInt("Image4Active", 0) == 1);
        image5.gameObject.SetActive(PlayerPrefs.GetInt("Image5Active", 0) == 1);
        
        image7.gameObject.SetActive(PlayerPrefs.GetInt("Image7Active", 0) == 1);
        image8.gameObject.SetActive(PlayerPrefs.GetInt("Image8Active", 0) == 1);
        image9.gameObject.SetActive(PlayerPrefs.GetInt("Image9Active", 0) == 1);
    }

    public void OnButtonClick()
    {
        // 이미지의 활성화 상태를 PlayerPrefs에 저장합니다.
        PlayerPrefs.SetInt("Image1Active", image1.gameObject.activeSelf ? 1 : 0);
        PlayerPrefs.SetInt("Image2Active", image2.gameObject.activeSelf ? 1 : 0);
        PlayerPrefs.SetInt("Image3Active", image3.gameObject.activeSelf ? 1 : 0);
        PlayerPrefs.SetInt("Image4Active", image4.gameObject.activeSelf ? 1 : 0);
        PlayerPrefs.SetInt("Image5Active", image5.gameObject.activeSelf ? 1 : 0);
        
        PlayerPrefs.SetInt("Image7Active", image7.gameObject.activeSelf ? 1 : 0);
        PlayerPrefs.SetInt("Image8Active", image8.gameObject.activeSelf ? 1 : 0);
        PlayerPrefs.SetInt("Image9Active", image9.gameObject.activeSelf ? 1 : 0);
        PlayerPrefs.Save();

        imageback.gameObject.SetActive(true);

        StartCoroutine(FadeAndReset()); // 페이드 아웃 후 씬 초기화 코루틴 시작

    }

    IEnumerator FadeAndReset()
    {
        isFading = true; // 페이드 아웃 시작
        yield return StartCoroutine(Fade(1.0f)); // 페이드 아웃 코루틴 실행




        // 현재 씬을 다시 로드하여 초기 화면으로 돌아감
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        Cursor.SetCursor(defaultCursor, Vector2.zero, CursorMode.Auto);

        // 씬이 로드된 후 이미지의 활성화 상태를 유지합니다.
        image1.gameObject.SetActive(PlayerPrefs.GetInt("Image1Active", 0) == 1);
        image2.gameObject.SetActive(PlayerPrefs.GetInt("Image2Active", 0) == 1);
        image3.gameObject.SetActive(PlayerPrefs.GetInt("Image3Active", 0) == 1);
        image4.gameObject.SetActive(PlayerPrefs.GetInt("Image4Active", 0) == 1);
        image5.gameObject.SetActive(PlayerPrefs.GetInt("Image5Active", 0) == 1);
        image6.gameObject.SetActive(PlayerPrefs.GetInt("Image6Active", 0) == 1);
        image7.gameObject.SetActive(PlayerPrefs.GetInt("Image7Active", 0) == 1);
        image8.gameObject.SetActive(PlayerPrefs.GetInt("Image8Active", 0) == 1);
        image9.gameObject.SetActive(PlayerPrefs.GetInt("Image9Active", 0) == 1);
        // 이미지의 활성화 상태를 PlayerPrefs에서 삭제합니다.

        PlayerPrefs.Save();


        bool CheckImages()
        {
            // 모든 이미지가 활성화되었는지 확인
            bool allImagesEnabled = true;
            foreach (Transform child in transform)
            {
                if (child.GetComponent<Image>() && !child.gameObject.activeSelf)
                {
                    allImagesEnabled = false;
                    break;
                }
            }

            // 모든 이미지가 활성화되었다면 다음 씬으로 이동합니다.
            if (allImagesEnabled)
                StartCoroutine(FadeAndReset());

            return allImagesEnabled;
        }



        IEnumerator Fade(float finalAlpha)
        {
            float fadeSpeed = Mathf.Abs(finalAlpha - fadeImage.color.a) / fadeDuration; // 페이드 속도 계산
            while (Mathf.Abs(finalAlpha - fadeImage.color.a) > 0.01f) // 목표 알파값에 도달할 때까지 반복
            {
                Color color = fadeImage.color;
                color.a = Mathf.MoveTowards(color.a, finalAlpha, fadeSpeed * Time.deltaTime); // 알파값 변경
                fadeImage.color = color;
                yield return null;
            }
            isFading = false; // 페이드 인 종료
        }
    }
}
