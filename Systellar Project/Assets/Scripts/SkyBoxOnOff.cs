using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyBoxOnOff : MonoBehaviour
{
    [SerializeField] private Camera mainCam;
    [SerializeField] private Skybox mainSkybox;

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
    }
}
