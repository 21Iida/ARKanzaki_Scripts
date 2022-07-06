using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// スクロールビューが一番下に来たら矢印アイコンを非表示にします
/// <summary>
public class ScrollArrowHide : MonoBehaviour
{
    [SerializeField] GameObject ScrollContent;
    private RectTransform rect;
    [SerializeField] float ContentEndY = 1000;

    void Start()
    {
        rect = ScrollContent.GetComponent<RectTransform>();
    }

    void Update()
    {
        if(rect.anchoredPosition.y >= ContentEndY)
        {
            this.GetComponent<Image>().enabled = false;
        }
        else
        {
            this.GetComponent<Image>().enabled = true;
        }
    }
}
