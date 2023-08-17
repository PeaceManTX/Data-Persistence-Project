using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuHandler : MonoBehaviour
{
    public TextMeshProUGUI userNameText;

    //public InputField inputField;
    public void GetName()
    {
        MainManager.Instance.userName = userNameText.text;
    }
    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }
    public void Exit()
    {
        MainManager.Instance.SaveScore();
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
    public void SaveScore()
    {
        MainManager.Instance.SaveScore();
    }

    public void LoadScore()
    {
        MainManager.Instance.LoadScore();
    }
}
