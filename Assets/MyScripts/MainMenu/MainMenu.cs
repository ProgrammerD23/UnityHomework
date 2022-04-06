using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Button quitButton;
    private void Awake()
    {
        quitButton.onClick.AddListener(() => { Application.Quit(); });
    }

}
