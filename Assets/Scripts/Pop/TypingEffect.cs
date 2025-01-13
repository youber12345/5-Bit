using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TypingEffect2 : MonoBehaviour
{
    public float delay = 0.1f;
    public string fullText = "금방 올 거에요. 제발, 아무것도 누르지 마세요!!"; // 출력할 텍스트
    private string currentText = "";
    private bool skip = false;

    public AudioSource audioSource; // 오디오 소스
    public AudioClip typingSound; // 타이핑 효과음

    void Start()
    {
        StartCoroutine(ShowText());
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            skip = true;
        }
    }

    IEnumerator ShowText()
    {
        for (int i = 0; i < fullText.Length; i++)
        {
            currentText = fullText.Substring(0, i);
            this.GetComponent<Text>().text = currentText;
            audioSource.PlayOneShot(typingSound); // 타이핑 효과음 재생
            if (skip)
            {
                this.GetComponent<Text>().text = fullText;
                break;
            }
            yield return new WaitForSeconds(delay);
        }
    }
}
