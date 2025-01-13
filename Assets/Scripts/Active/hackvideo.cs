using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class hackvideo : MonoBehaviour
{
   

    public RawImage RawImage1, RawImage2;
    public VideoPlayer videoPlayer1, videoPlayer2;
    public AudioSource audioSource;
    public AudioClip newBackgroundMusic;
    public Button interactableButton, interactableButton2;
    public GameObject text1, image1, image2;

   

    // Update is called once per frame
    public void OnButtonclick()
    {
        StartCoroutine(FadeInVideoAndChangeMusic14());
    }

    IEnumerator FadeInVideoAndChangeMusic14()
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
