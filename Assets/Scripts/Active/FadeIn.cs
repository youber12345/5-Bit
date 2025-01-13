using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour
{
    public Image imageToFade; // Fade를 적용할 이미지
    public float fadeInTime; // Fade가 진행될 시간

    private void OnEnable()
    {
        StartCoroutine(FadeImageIn());
    }

    IEnumerator FadeImageIn()
    {
        Color color = imageToFade.color;
        float elapsedTime = 0f;

        while (elapsedTime < fadeInTime)
        {
            elapsedTime += Time.deltaTime;
            color.a = Mathf.Clamp01(elapsedTime / fadeInTime);
            imageToFade.color = color;
            yield return null;
        }
    }
}