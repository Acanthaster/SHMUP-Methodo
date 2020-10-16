using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    public void Replay()
    {
        SceneManager.LoadScene("Level1");
    }

    public void Menu()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }

    public void Quit()
    {
        Application.Quit();
    }

}
