using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackToMainCam : MonoBehaviour
{
    [SerializeField] private Camera backToCamera;
    [SerializeField] private Canvas mainCanvas;

    public void BackToMain()
    {
        backToCamera.enabled = false;
        mainCanvas.enabled = false;
    }
}
