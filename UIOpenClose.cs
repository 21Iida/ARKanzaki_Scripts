//タイトル画面で使い方画面、設定画面の行き来をする

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIOpenClose : MonoBehaviour
{
    [SerializeField] GameObject UseUI,SettingUI;

    void Start()
    {
        UseUI.SetActive(false);
        SettingUI.SetActive(false);
    }

    public void OnUseUI()
    {
        UseUI.SetActive(true);
    }

    public void OffUseUI()
    {
        UseUI.SetActive(false);
    }

    public void OnSettingUI()
    {
        SettingUI.SetActive(true);
    }

    public void OffSettingUI()
    {
        SettingUI.SetActive(false);
    }
}
