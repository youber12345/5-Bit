using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class ObjectController : MonoBehaviour
{
    public float jumpHeight = 0.2f; // 조정 가능한 점프 높이
    public int spacebarPresses = 10; // 스페이스바를 눌러야 하는 횟수

    public RawImage RawImage1, RawImage2;
    public VideoPlayer videoPlayer1, videoPlayer2;
    public AudioSource audioSource;
    public AudioClip newBackgroundMusic;
    public Button interactableButton, interactableButton2;
    public GameObject text1, image1, image2;

    private bool isCoroutineRunning = false; // 코루틴이 실행 중인지 확인하는 플래그
    private int currentPresses = 0; // 현재 스페이스바를 누른 횟수

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + jumpHeight, transform.position.z);
            currentPresses++;

            if (currentPresses >= spacebarPresses && !isCoroutineRunning)
            {
                StartCoroutine(FadeInVideoAndChangeMusic());
            }
        }
    }

    IEnumerator FadeInVideoAndChangeMusic()
    {
        isCoroutineRunning = true; // 코루틴 시작

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

        image2.gameObject.SetActive(false);
    }
}
