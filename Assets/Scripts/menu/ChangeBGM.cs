using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBGM : MonoBehaviour
{
    public AudioClip newAudioClip; // 새로운 오디오 클립
    public float volume = 1.0f; // 오디오 볼륨
    public bool loop = false; // 오디오 루프 여부
    private AudioSource audioSource; // 오디오 소스 컴포넌트
    private bool audioChanged = false; // 오디오 변경 여부

    void Start()
    {
        audioSource = GetComponent<AudioSource>(); // 오디오 소스 컴포넌트 가져오기
    }

    public void OnButtonClick()
    {
        if (!audioChanged)
        {
            audioSource.clip = newAudioClip; // 오디오 클립 변경
            audioSource.volume = volume; // 오디오 볼륨 설정
            audioSource.loop = loop; // 오디오 루프 설정
            audioSource.Play(); // 새로운 오디오 재생
            audioChanged = true;
        }
    }
}