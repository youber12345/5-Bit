using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{
    public RawImage RawImage1, RawImage2;
    public VideoPlayer videoPlayer1, videoPlayer2;
    public Text text1;
    public Image image1;
    public Button interactableButton, interactableButton2;
    public AudioSource audioSource;
    public AudioClip newBackgroundMusic;

    public Button button1, button2, button3, button4;
    

    private int[] correctOrder = { 1, 2, 3, 4 }; // 올바른 버튼 누르는 순서
    private int currentButtonIndex = 0;

    void Start()
    {
        // 각 버튼의 클릭 이벤트에 OnButtonPress 함수를 연결합니다.
        button1.onClick.AddListener(() => OnButtonPress(1));
        button2.onClick.AddListener(() => OnButtonPress(2));
        button3.onClick.AddListener(() => OnButtonPress(3));
        button4.onClick.AddListener(() => OnButtonPress(4));
    }

    private void OnButtonPress(int buttonNumber)
    {
        if (buttonNumber == correctOrder[currentButtonIndex])
        {
            currentButtonIndex++;

            if (currentButtonIndex == correctOrder.Length)
            {
                StartCoroutine(FadeInVideoAndChangeMusic());
                currentButtonIndex = 0; // 인덱스를 초기화합니다.
            }
        }
        else
        {
            currentButtonIndex = 0; // 버튼이 잘못 눌렸으므로 인덱스를 초기화합니다.
        }
    }

    IEnumerator FadeInVideoAndChangeMusic()
    {
        // 비디오와 음악을 바꾸기 전에 페이드아웃 효과를 줍니다.
        for (float i = 1; i >= 0; i -= Time.deltaTime)
        {
            // RawImage의 알파값을 조절하여 페이드아웃 효과를 줍니다.
            Color color = RawImage1.color;
            color.a = i;
            RawImage1.color = color;

            Button[] allButtons = FindObjectsOfType<Button>();
            foreach (Button button in allButtons)
            {
                button.interactable = false;
            }

            // 특정 버튼만 다시 활성화합니다.
            interactableButton.interactable = true;
            interactableButton2.interactable = true;

            yield return null;
        }

        videoPlayer1.Stop();
        videoPlayer1.gameObject.SetActive(false);
        RawImage1.gameObject.SetActive(false);
       


        // 새로운 비디오와 음악을 활성화합니다.
        RawImage2.gameObject.SetActive(true);
        videoPlayer2.gameObject.SetActive(true);
        videoPlayer2.Play();

        // 배경음악을 바꿉니다.
        audioSource.clip = newBackgroundMusic;
        audioSource.Play();

        image1.gameObject.SetActive(true);
    }
}
