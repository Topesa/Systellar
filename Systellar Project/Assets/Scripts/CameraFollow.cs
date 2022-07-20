using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Camera targetFollow;

    [SerializeField] private Canvas canvas;

    public void Follow()
    {
        targetFollow.enabled = true;
        canvas.enabled = true;
    }
}

