using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow2 : MonoBehaviour
{
    public Transform tr;
    private Vector3 cameraOffset;
    public float smoothFactor;
    public bool lookAt = false;

    private void Start()
    {
        cameraOffset = transform.position - tr.position;
    }

    private void LateUpdate()
    {
        Vector3 newPos = tr.position + cameraOffset;

        transform.position = Vector3.Slerp(transform.position, newPos, smoothFactor);

        if (lookAt)
        {
            transform.LookAt(tr);
        }
    }
}
