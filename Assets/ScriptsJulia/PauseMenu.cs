using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool gameIsPaused = false;
    public GameObject pauseMenuUI; 
    
    void Start()
    {
        pauseMenuUI.GetComponent<RectTransform>().localScale = Vector3.zero;

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("ohohoh");
            if (gameIsPaused)
            {
                //Debug.Log("appuie");
                Resume();
            }
            else
            {
                //Debug.Log("poney echappe");
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.GetComponent<RectTransform>().localScale = Vector3.zero;
        Time.timeScale = 1f;
        gameIsPaused = false;
    }

    public void Pause()
    {
        pauseMenuUI.GetComponent<RectTransform>().localScale = Vector3.one;
        Time.timeScale = 0f;
        gameIsPaused = true;
    }

    public void Menu()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }
}
