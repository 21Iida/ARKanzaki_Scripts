using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

/// <summary>
/// 矢印をループアニメーションさせます
/// <summary>
public class UIAnimationUpDown : MonoBehaviour
{
    [SerializeField] float DurationSeconds;
    [SerializeField] Ease EaseType;

    RectTransform rect;
    Vector3 defaultVec;
    [SerializeField] Vector3 afterVec;

    void Start()
    {
        rect = this.GetComponent<RectTransform>();
        defaultVec = rect.anchoredPosition;
        afterVec += defaultVec;
        this.transform.DOLocalMove(afterVec,DurationSeconds).SetEase(this.EaseType).SetLoops(-1, LoopType.Yoyo);
    }
}
