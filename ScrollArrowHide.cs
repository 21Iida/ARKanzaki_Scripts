using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollArrowHide : MonoBehaviour
{
    //スクロールビューが一番したに来たら矢印を非表示にしたい
    [SerializeField] GameObject ScrollContent;
    private RectTransform rect;
    [SerializeField] float ContentEndY = 1000;

    // Start is called before the first frame update
    void Start()
    {
        rect = ScrollContent.GetComponent<RectTransform>();
    }

    // Update is called once per frame
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
