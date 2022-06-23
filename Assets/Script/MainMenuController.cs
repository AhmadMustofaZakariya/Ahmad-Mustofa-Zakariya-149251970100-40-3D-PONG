using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void playGame()
    {
        SceneManager.LoadScene("Gameplay",LoadSceneMode.Single);
    }

    public void howToPlayGame()
    {
        SceneManager.LoadScene("How to Play");
    }

    public void Exit()
    {
        Application.Quit();
    }    
}
