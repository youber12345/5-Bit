using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeVolume : MonoBehaviour
{
    public AudioSource audioSource; // 오디오 소스 컴포넌트
    private float initialVolume; // 초기 볼륨
    private int clickCount = 0; // 클릭 횟수

    void Start()
    {
        initialVolume = audioSource.volume; // 초기 볼륨 저장
    }

    public void OnButtonClick()
    {
        clickCount++;
        if (clickCount == 1)
        {
            audioSource.volume = initialVolume * 0.66f; // 볼륨 1단계 감소
        }
        else if (clickCount == 2)
        {
            audioSource.volume = initialVolume * 0.33f; // 볼륨 2단계 감소
        }
        else if (clickCount == 3)
        {
            audioSource.volume = 0.0f; // 볼륨 3단계 감소 (음소거)
        }
        else
        {
            audioSource.volume = initialVolume; // 볼륨 초기 상태로 복원
            clickCount = 0;
        }
    }
}