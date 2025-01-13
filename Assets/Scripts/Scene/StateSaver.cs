using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StateSaver : MonoBehaviour
{
    public static StateSaver Instance; // 싱글톤 인스턴스

    public bool image1Active;
    public bool image2Active;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this; // 싱글톤 인스턴스 설정
            DontDestroyOnLoad(gameObject); // 씬 변경 시 파괴되지 않도록 설정
        }
        else
        {
            Destroy(gameObject); // 이미 인스턴스가 있는 경우 파괴
        }
    }
}