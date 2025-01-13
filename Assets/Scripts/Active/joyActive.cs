using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class joyActive : MonoBehaviour
{
    public Button yourButton;
    public VideoPlayer videoPlayer;
    private int clickCount = 0;
    public GameObject joy;

    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        clickCount++;
        if (clickCount == 15)
        {
            joy.SetActive(true);
            videoPlayer.Play();

        }
    }
}