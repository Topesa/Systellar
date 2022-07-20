using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow2 : MonoBehaviour
{
    [SerializeField] private Transform tr;
    [SerializeField] private float smoothFactor;
    [SerializeField] private bool lookAt;

    private Vector3 cameraOffset;

    private void Start()
    {
        cameraOffset = transform.position - tr.position;
    }

    private void LateUpdate()
    {
        Follow();
    }

    private void Follow()
    {
        Vector3 newPos = tr.position + cameraOffset;

        transform.position = Vector3.Slerp(transform.position, newPos, smoothFactor);

        if (lookAt)
        {
            transform.LookAt(tr);
        }
    }
}
