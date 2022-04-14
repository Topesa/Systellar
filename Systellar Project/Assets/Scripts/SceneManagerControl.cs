using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerControl : MonoBehaviour
{
    public void SimulationLoad()
    {
        SceneManager.LoadScene(1);
    }

    public void PlanetInfoLoad()
    {
        SceneManager.LoadScene(2);
    }

    public void ExitProgram()
    {
        // Debug.Log("Exit test");
        Application.Quit();
    }
}
