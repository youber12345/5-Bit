using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Activateimagee : MonoBehaviour
{
    public Image newImage; // 활성화할 이미지
    public Button interactableButton; // 활성화할 버튼1
    public Button interactableButton2; // 활성화할 버튼2
    public Button redButton; // 새로 추가된 버튼

    private float timer = 0;
    private bool objectActivated = false; // objectActivated 변수를 다시 선언했습니다.

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (!redButton.GetComponent<Button>().interactable)
            {
                timer = 0;
            }
        }
        else
        {
            timer += Time.deltaTime;
            if (timer >= 10 && !objectActivated)
            {
                StartCoroutine(ActivateNewImage());
            }
        }
    }

    IEnumerator ActivateNewImage()
    {
        objectActivated = true;

        // 모든 버튼을 비활성화합니다.
        Button[] allButtons = FindObjectsOfType<Button>();
        foreach (Button button in allButtons)
        {
            button.interactable = false;
        }

        // 특정 두 버튼만 다시 활성화합니다.
        interactableButton.interactable = true;
        interactableButton2.interactable = true;

        // 새로운 이미지를 활성화합니다.
        newImage.gameObject.SetActive(true);

        yield return null;
    }
}
