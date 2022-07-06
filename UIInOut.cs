using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

/// <summary>
/// UIを初期位置から動かす関数と、初期位置に戻す関数
/// <summary>
public class UIInOut : MonoBehaviour
{
    Vector3 defaultVec;
    [SerializeField] Vector3 afterVec;
    RectTransform rect;

    void Awake()
    {
        rect = this.GetComponent<RectTransform>();
        defaultVec = rect.anchoredPosition;
    }

    public void UIAfter()
    {
        rect.DOAnchorPos(afterVec,0.3f);
    }

    public void UIBefore()
    {
        rect.DOAnchorPos(defaultVec,0.3f);
    }
}
