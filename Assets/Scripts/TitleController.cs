using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleController : MonoBehaviour
{
    GameObject gameCanvas;
    private void Awake()
    {
        SceneManager.LoadScene("MainGame", LoadSceneMode.Additive);

    }
    void Start()
    {
        gameCanvas = GameObject.Find("MainGameCanvas");
        gameCanvas.SetActive(false);
    }
    void Update()
    {
        
    }
    public void StartButton()
    {
        SceneManager.UnloadSceneAsync("TitleScene");
        gameCanvas.SetActive(true);
    }
}
