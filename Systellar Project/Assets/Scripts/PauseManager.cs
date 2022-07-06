using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    public static bool gameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject mainCanvas;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Resume()
    {
        mainCanvas.SetActive(true);
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }

    void Pause()
    {
        mainCanvas.SetActive(false);
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }

    public void SimulationSceneChange()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }

    public void PlanetInfoSceneChange()
    {
        SceneManager.LoadScene(2);
        Time.timeScale = 1f;
    }

    public void MainMenuSceneChange()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }
    
    public void Exit()
    {
        Application.Quit();
        //Debug.Log("Exit test");
    }
}
