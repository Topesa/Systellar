using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackToMainCam : MonoBehaviour
{
    public Camera backToCamera;
    public Canvas mainCanvas;    
   
    public void BackToMain()
    {
        backToCamera.enabled = false;
        mainCanvas.enabled = false;        
    }
}
