using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyBoxOnOff : MonoBehaviour
{
    [SerializeField] Camera mainCam;
    [SerializeField] Skybox mainSkybox;

    public void DisableSkybox()
    {
        if (mainSkybox.isActiveAndEnabled)
        {
            mainSkybox.enabled = false;
        }
        else
        {
            mainSkybox.enabled = true;
        }
        //mainCam.GetComponent<Skybox>().enabled = false;
    }
}
