using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class PianoActive : MonoBehaviour
{
    public Button yourButton;
    public VideoPlayer videoPlayer;
    private int clickCount = 0;
    public GameObject piano;

    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        clickCount++;
        if (clickCount == 12)
        {
            piano.SetActive(true);
            videoPlayer.Play();

        }
    }
}