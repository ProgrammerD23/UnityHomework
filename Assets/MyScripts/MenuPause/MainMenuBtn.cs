using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuBtn : MonoBehaviour
{
    public Button _MainMenuBtn;
    void Awake()
    {
        _MainMenuBtn.onClick.AddListener(InMainMenu);
    }

    private void InMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
