using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveLaber : MonoBehaviour
{
    public GameObject Laber;
    int clickCount = 0;
    public float speed = 1.0f; // 애니메이션 속도를 조절합니다.
    Vector3 startPosition; // 시작 위치를 저장합니다.
    Vector3 endPosition; // 종료 위치를 저장합니다.

    void Start()
    {
        startPosition = new Vector3(Laber.transform.position.x, Laber.transform.position.y - 20, Laber.transform.position.z); // 시작 위치를 설정합니다.
        endPosition = Laber.transform.position; // 종료 위치를 설정합니다.
        Laber.transform.position = startPosition; // 오브젝트의 위치를 시작 위치로 설정합니다.
        
    }

    public void OnButtonClick()
    {
        clickCount++;
        if (clickCount == 1)
        {
            Laber.SetActive(true);
            StartCoroutine(MoveObject(Laber, startPosition, endPosition, speed)); // 코루틴을 시작하여 오브젝트를 움직입니다.
        }
    }

    IEnumerator MoveObject(GameObject obj, Vector3 start, Vector3 end, float time)
    {
        float i = 0.0f;
        float rate = 1.0f / time;
        while (i < 1.0f)
        {
            i += Time.deltaTime * rate;
            obj.transform.position = Vector3.Lerp(start, end, i);
            yield return null;
        }
    }
}