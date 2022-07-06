using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class NumberButtonUpDown : MonoBehaviour
{
    InputField inputField;
    float fieldFloat;
    float udSize = 1f;

    void Start()
    {
        inputField = this.GetComponent<InputField>();
    }

    public void UpNumberButton()
    {
        if(float.TryParse(inputField.text, out float result))
        {
            fieldFloat = float.Parse(inputField.text);
            fieldFloat += udSize;
            inputField.text = fieldFloat.ToString();
        }
    }
    public void DownNumberButton()
    {
        if(float.TryParse(inputField.text, out float result))
        {
            fieldFloat = float.Parse(inputField.text);
            fieldFloat -= udSize;
            inputField.text = fieldFloat.ToString();
        }
    }
    
}
