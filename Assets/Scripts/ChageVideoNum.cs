using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class ChangeVideo : MonoBehaviour
{
    public VideoPlayer videoPlayer1; //원본 비디오
    public VideoPlayer videoPlayer2;  //황금비 비디오
    public VideoPlayer videoPlayer3; // 코나미 비디오
    public VideoPlayer videoPlayer4; // 핵폭발 비디오
    public VideoPlayer videoPlayer5; //피아노 비디오


    public RawImage RawImage1; //원본 로우 이미지
    public RawImage RawImage2; //황금비 로우 이미지
    public RawImage RawImage3; // 코나미 로우 이미지
    public RawImage RawImage4; // 핵폭발 로우 이미지
    public RawImage RawImage5; // 피아노 로우 이미지


    public Text text1; //황금비 텍스트
    public Text text2; //코나미 텍스트
    public Text text3; //피아노 텍스트

    public Image image1; //황금비 이미지
    public Image image2; // 코나미 이미지
    public Image image3; // 핵 이미지
    public Image image4; //피아노 이미지

    public Image image5; // 순종 이미지 다이얼로그
    public Image image6; // 순종 이미지

    public Image image7; //과부화 이미지
 
    public string correctText = "16180";  //황금비 맞출거
    public string coreectText1 = "↑↓↑↓←→←→PK"; //코나미 맞출거
    public string coreectText2 = "EEECEGG"; //피아노 맞출거

    public AudioSource audioSource; // 배경음악을 제어하기 위한 AudioSource 컴포넌트를 추가. 
    public AudioClip newBackgroundMusic; // 새로운 배경음악 클립을 추가 , 황금비 배경음악
    public AudioClip newBackgroundMusic1; // 코나미 배경음악
    public AudioClip newBackgroundMusic2; // 핵폭발 배경음악
    public AudioClip newBackgroundMusic3; // 순종 배경음악
    public AudioClip newBackgroundMusic4; //피아노 배경음악


    public Button interactableButton;
    public Button interactableButton2;  // 움직여야하는 버튼


    private float timeElapsed = 0f; // 경과 시간
    private bool buttonClicked = false; // 버튼이 클릭되었는지 확인하는 변수



    int clickCount = 0;

    void Start()
    {
        // 게임이 재시작되었을 때 이미지를 활성화합니다.
        if (PlayerPrefs.GetInt("ButtonClicked35Times", 0) == 1)
        {
            image7.gameObject.SetActive(true);
        }
    }


    void Update()
    {
        // 버튼이 클릭되지 않았을 때만 경과 시간을 증가시킵니다.
        if (!buttonClicked)
        {
            timeElapsed += Time.deltaTime;

            // 경과 시간이 1분이 되면 비디오 플레이어를 활성화합니다.
            if (timeElapsed >= 60f)
            {
                StartCoroutine(FadeInVideoAndChangeMusic3());
            }
        }
    }



    public void OnButtonClick()
    {
        clickCount++;
        buttonClicked = true;
        timeElapsed = 0f;
        
        if (clickCount == 35)
        {
           
            PlayerPrefs.SetInt("ButtonClicked35Times", 1);
            PlayerPrefs.Save();
            #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
            #else
            Application.Quit();
            #endif
        }
        else if (text1.text == correctText)
        {
            StartCoroutine(FadeInVideoAndChangeMusic());
        }
        else if (text2.text == coreectText1)
        {
            StartCoroutine(FadeInVideoAndChangeMusic1());
        }
        else if (text3.text == coreectText2)
        {
            StartCoroutine(FadeInVideoAndChangeMusic4());
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
        text1.gameObject.SetActive(false);


        // 새로운 비디오와 음악을 활성화합니다.
        RawImage2.gameObject.SetActive(true);
        videoPlayer2.gameObject.SetActive(true);
        videoPlayer2.Play();

        // 배경음악을 바꿉니다.
        audioSource.clip = newBackgroundMusic;
        audioSource.Play();

        image1.gameObject.SetActive(true);


    }

    IEnumerator FadeInVideoAndChangeMusic1()
    {
        // 비디오와 음악을 바꾸기 전에 페이드아웃 효과를 줍니다.
        for (float i = 1; i >= 0; i -= Time.deltaTime)
        {


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
        text2.gameObject.SetActive(false);


        // 새로운 비디오와 음악을 활성화합니다.
        RawImage3.gameObject.SetActive(true);
        videoPlayer3.gameObject.SetActive(true);
        videoPlayer3.Play();

        // 배경음악을 바꿉니다.
        audioSource.clip = newBackgroundMusic1;
        audioSource.Play();

        image2.gameObject.SetActive(true);


    }

    IEnumerator FadeInVideoAndChangeMusic2()
    {
        // 비디오와 음악을 바꾸기 전에 페이드아웃 효과를 줍니다.
        for (float i = 1; i >= 0; i -= Time.deltaTime)
        {


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
        RawImage4.gameObject.SetActive(true);
        videoPlayer4.gameObject.SetActive(true);
        videoPlayer4.Play();

        // 배경음악을 바꿉니다.
        audioSource.clip = newBackgroundMusic2;
        audioSource.Play();


        image3.gameObject.SetActive(true);
    }

    IEnumerator FadeInVideoAndChangeMusic3()
    {
        // 비디오와 음악을 바꾸기 전에 페이드아웃 효과를 줍니다.
        for (float i = 1; i >= 0; i -= Time.deltaTime)
        {


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


     

        // 배경음악을 바꿉니다.
        audioSource.clip = newBackgroundMusic3;
        audioSource.Play();


        
        image5.gameObject.SetActive(true);
        image6.gameObject.SetActive(true);

      
    }

    IEnumerator FadeInVideoAndChangeMusic4()
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

        image4.gameObject.SetActive(true);

        videoPlayer1.Stop();
        videoPlayer1.gameObject.SetActive(false);
        RawImage1.gameObject.SetActive(false);
        text1.gameObject.SetActive(false);


        // 새로운 비디오와 음악을 활성화합니다.
        RawImage5.gameObject.SetActive(true);
        videoPlayer5.gameObject.SetActive(true);
        videoPlayer5.Play();

        // 배경음악을 바꿉니다.
        audioSource.clip = newBackgroundMusic4;
        audioSource.Play();

        


    }
}