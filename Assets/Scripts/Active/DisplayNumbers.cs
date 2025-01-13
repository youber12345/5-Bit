using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayNumbers : MonoBehaviour
{
    public Text displayText; // 인스펙터에서 Text 컴포넌트를 할당합니다.
    private string currentText = "";

    public void AddNumber(int number)
    {
        currentText += number.ToString();
        displayText.text = currentText;

        if (currentText.Length >= 6)
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