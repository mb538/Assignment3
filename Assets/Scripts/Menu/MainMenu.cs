using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void CarGame()
    {
        SceneManager.LoadScene("CarGame");
    }

    public void ThirdPersonGame()
    {
        SceneManager.LoadScene("ThirdPerson");
    }

    public void FlyGame()
    {
        SceneManager.LoadScene("FlyGame");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
