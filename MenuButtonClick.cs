using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;

/// <summary>
/// デバッグ用。実機で弄れるインスペクター画面のオンオフ
/// <summary>
public class MenuButtonClick : MonoBehaviour
{
    [SerializeField] Toggle toglle;

    void Start()
    {
        //button = this.gameObject.GetComponent<Button>();
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            InUI();
        }
        if(Input.GetKeyDown(KeyCode.Q))
        {
            OutUI();
        }
    }
    
    public void OnClick()
    {
        this.transform.DOScale(2.2f, 0.8f).SetEase(Ease.OutElastic);
        SceneManager.LoadScene("Main");
    }
    public void InOutSwich()
    {
        if(toglle.isOn)
        {
            InUI();
        } else {
            OutUI();
        }
    }
    public void InUI()
    {
        this.GetComponent<RectTransform>().DOLocalMoveX(0,0.5f).SetEase(Ease.InOutBack);
    }
    public void OutUI()
    {
        this.GetComponent<RectTransform>().DOLocalMoveX(-800f,0.5f).SetEase(Ease.InSine);
    }

}
