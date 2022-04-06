using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    public Button levelBtn;
    public string nameLevel;

    private void Awake()
    {
        levelBtn.onClick.AddListener(SatrtLevel);
    }

    private void SatrtLevel()
    {
        SceneManager.LoadScene(nameLevel);
    }

}
