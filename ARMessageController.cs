using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 操作説明用のメッセージを表示します
/// <summary>
public class ARMessageController : MonoBehaviour
{

    float alpha = 0.8f;
    float maxAlpha = 1.0f;
    float fadeSpeed = 0.03f;

    bool fadeIn = false;
    bool fadeOut = false;

    public int phaseIndex;

    public bool isShowing = true;
    string messageString = "";

    void Start()
    {
        changeText(0);
    }

    void Update()
    {
        if(isShowing && alpha < maxAlpha){
            fadeIn = true;
        }
        if(!isShowing && alpha > 0.0f){
            fadeOut = true;
        }

        if(fadeIn){
            alpha += fadeSpeed;
            if(alpha > maxAlpha){
                alpha = maxAlpha;
                fadeIn = false;
            }
        }
        if(fadeOut)
        {
            alpha -= fadeSpeed;
            if(alpha <= 0)
            {
                alpha = 0.0f;
                fadeOut = false;
                if(phaseIndex == 0)
                {
                    changeText(1); // 初期表示から次のメッセージへ転換
                }
            }
        }

        gameObject.GetComponent<CanvasGroup>().alpha = alpha;

    }

    public void changeText(int newIndex)
    {
        phaseIndex = newIndex;
        switch(phaseIndex)
        {
            case 0:
                messageString = "看板のQRコードを写してください";
                break;
            case 1:
                messageString = "看板のQRコードを写してください";
                break;
        }
        gameObject.transform.Find("Text").GetComponent<Text>().text = messageString;

        this.isShowing = true;
    }
}
