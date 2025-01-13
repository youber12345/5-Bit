using UnityEngine;
using UnityEngine.Video;

public class VideoEndGame : MonoBehaviour
{
    public VideoPlayer videoPlayer; // 재생할 비디오 플레이어

    void Start()
    {
        // 비디오 재생이 끝났을 때의 동작을 설정합니다.
        videoPlayer.loopPointReached += EndReached;
    }

    void EndReached(VideoPlayer vp)
    {
        // 비디오 재생이 끝났을 때 게임을 종료합니다.
        Application.Quit();
    }
}
