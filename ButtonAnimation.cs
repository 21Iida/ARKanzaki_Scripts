using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

/// <summary>
/// クリックしたボタンのアニメーションをさせるやつです
/// ボタンのスケールの値は(1,1,1)じゃないとアニメーション終了時にUIがおかしくなります
/// <summary>
public class ButtonAnimation : MonoBehaviour
{
    Tweener tweener = null;

    void Awake()
    {
        //毎回インスペクターからonClickを設定するのが面倒なのでAddListenerで検知してラムダ式を走らせる
        //アニメーション本体は<https://qiita.com/nkjzm/items/8c8b38e45c3e7712cd74>を参考にした
        GetComponent<Button>().onClick.AddListener(() =>
        {
            if (tweener != null)
            {
                tweener.Kill();
                tweener = null;
                transform.localScale = Vector3.one;
            }
            tweener = transform.DOPunchScale(
                punch: Vector3.one * 0.1f,
                duration: 0.2f,
                vibrato: 1
            ).SetEase(Ease.OutExpo);
        });
    }

}
