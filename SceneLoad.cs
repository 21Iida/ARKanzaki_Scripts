using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// シーンの切り替えをします
/// <summary>
public class SceneLoad : MonoBehaviour
{
    public void GoTitle()
    {
        SceneManager.LoadScene("Title");
    }

    public void GoMain()
    {
        SceneManager.LoadScene("Main");
    }
}
