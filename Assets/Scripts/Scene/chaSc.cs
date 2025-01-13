using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement; // 이 부분을 추가

public class chaSc : MonoBehaviour
{
    public string nextSceneName; // 다음 씬의 이름
    public VideoPlayer videoPlayer; // 비디오 플레이어

    void Start()
    {
        videoPlayer.loopPointReached += OnVideoEnd;
    }

    void OnVideoEnd(VideoPlayer vp)
    {
        SceneManager.LoadScene(nextSceneName); // 다음 씬으로 이동
    }
}
