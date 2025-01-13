using UnityEngine;
using UnityEngine.Video;

public class VideoEndGame1 : MonoBehaviour
{
    public VideoPlayer videoPlayer; // 비디오 플레이어를 참조합니다.

    void Start()
    {
        // 비디오 재생이 끝났을 때 호출될 이벤트를 설정합니다.
        videoPlayer.loopPointReached += OnVideoEnded;
    }

    void OnVideoEnded(VideoPlayer vp)
    {
        // 비디오 재생이 끝나면 게임을 종료합니다.
        Application.Quit();
    }
}
