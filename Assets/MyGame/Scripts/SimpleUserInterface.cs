using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimpleUserInterface : MonoBehaviour
{
    public Text result_text;
    public Text result_number;
    public InputField var_a;
    public Button button_a;
    public Button button_b;
    
    int intCount = 1;

    public void ConfirmText()
    {
      result_text.text = var_a.text;
    }
    
    public void CountNumbers()
    {
      intCount++;
      result_number.text = intCount.ToString();
    }
}
