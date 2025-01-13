using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class displayPiano : MonoBehaviour
{
    public Text pianoText; // 인스펙터에서 Text 컴포넌트를 할당합니다.
    private string currentText = "";

    public void AddLetter(string letter)
    {
        currentText += letter;
        pianoText.text = currentText;

        if (currentText.Length >= 8)
        {
            currentText = "";
            pianoText.text = "";
        }
    }
    public void ClearDisplay()
    {
        currentText = "";
        pianoText.text = "";
    }
}