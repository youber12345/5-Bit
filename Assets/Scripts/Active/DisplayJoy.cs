using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayText : MonoBehaviour
{
    public Text displayText; // 인스펙터에서 Text 컴포넌트를 할당합니다.
    private string currentText = "";

    public void AddText(string text)
    {
        currentText += text;
        displayText.text = currentText;

        if (currentText.Length >= 11)
        {
            currentText = "";
            displayText.text = "";
        }
    }
    public void ClearDisplay()
    {
        currentText = "";
        displayText.text = "";
    }
}