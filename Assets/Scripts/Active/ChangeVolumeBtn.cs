using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeVolumeBtn : MonoBehaviour
{
    public Sprite[] buttonSprites; // 버튼 스프라이트 배열
    private Image buttonImage; // 버튼 이미지 컴포넌트
    private int currentSpriteIndex = 0; // 현재 스프라이트 인덱스

    void Start()
    {
        buttonImage = GetComponent<Image>(); // 버튼 이미지 컴포넌트 가져오기
    }

    public void OnButtonClick()
    {
        currentSpriteIndex = (currentSpriteIndex + 1) % (buttonSprites.Length + 1); // 다음 스프라이트 인덱스 계산
        if (currentSpriteIndex == buttonSprites.Length)
        {
            buttonImage.sprite = null; // 초기 스프라이트로 변경
        }
        else
        {
            buttonImage.sprite = buttonSprites[currentSpriteIndex]; // 버튼 스프라이트 변경
        }
    }
}