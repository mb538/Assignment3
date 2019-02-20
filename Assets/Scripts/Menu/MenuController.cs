using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MenuController : MonoBehaviour
{
    private bool gamePaused = false;
    public GameObject pauseMenu;
    public GameObject gameUI;

    private void Awake()
    {
        AudioListener.pause = false;
        pauseMenu.SetActive(true);
        gameUI.SetActive(true);
    }
    void Start()
    {
        ResumeGame();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && gamePaused == true)
        {
            ResumeGame();
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && gamePaused == false)
        {
            EventSystem.current.SetSelectedGameObject(null);
            FreezeGame();
        }

    }

    public void ResumeGame()
    {
        gamePaused = false;
        AudioListener.pause = false;
        Time.timeScale = 1;
        HideCanvas();
    }

    public void FreezeGame()
    {
        gamePaused = true;
        AudioListener.pause = true;
        Time.timeScale = 0;
        ShowCanvas();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void CarGame()
    {
        SceneManager.LoadScene("CarGame");
    }

    public void ThirdPersonGame()
    {
        SceneManager.LoadScene("3rdPerson");
    }

    public void FlyGame()
    {
        SceneManager.LoadScene("FlyGame");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ShowCanvas()
    {
        pauseMenu.GetComponent<Canvas>().enabled = true;
        pauseMenu.GetComponent<CanvasScaler>().enabled = true;
    }

    public void HideCanvas()
    {
        pauseMenu.GetComponent<Canvas>().enabled = false;
        pauseMenu.GetComponent<CanvasScaler>().enabled = false;
    }
}
