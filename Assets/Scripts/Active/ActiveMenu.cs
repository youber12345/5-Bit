using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActiveMenu : MonoBehaviour
{
    public Button yourButton;
    public Button yourInnerButton;
    public Button yourInnerButton1;
    public Button yourInnerButton2;
    public Image yourImage;

    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        yourImage.enabled = false;
        yourInnerButton.gameObject.SetActive(false);
        yourInnerButton1.gameObject.SetActive(false);
        yourInnerButton2.gameObject.SetActive(false);
    }

    void TaskOnClick()
    {
        yourImage.enabled = !yourImage.enabled;
        yourInnerButton.gameObject.SetActive(yourImage.enabled);
        yourInnerButton1.gameObject.SetActive(yourImage.enabled);
        yourInnerButton2.gameObject.SetActive(yourImage.enabled);
    }
}