using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

/// <summary>
/// ボタンを強調させるアニメーションをします
/// <summary>
public class UIAnimationScale : MonoBehaviour
{
    [SerializeField] float DurationSeconds;
    [SerializeField] Ease EaseType;

    RectTransform rect;
    Vector3 defaultVec;
    [SerializeField] Vector3 afterSize;

    void Start()
    {
        rect = this.GetComponent<RectTransform>();
        defaultVec = rect.anchoredPosition;
        //afterSize += defaultVec;
        this.transform.DOScale(afterSize,DurationSeconds).SetEase(this.EaseType).SetLoops(-1, LoopType.Yoyo);
    }
}
