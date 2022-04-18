using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// buttonのテキストを変えるだけ
/// </summary>
public class ButtonTextChange : MonoBehaviour
{
    [SerializeField] string DefaultText,AfterText;


    public void ButtonTextDefault()
    {
        this.transform.GetComponentInChildren<Text>().text = DefaultText;
    }

    public void ButtonTextAfter()
    {
        this.transform.GetComponentInChildren<Text>().text = AfterText;
    }
}
