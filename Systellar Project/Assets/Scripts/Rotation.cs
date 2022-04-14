using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] private Vector3 rotation;
    [SerializeField] private float speed;

    void LateUpdate()
    {
        transform.Rotate(rotation * speed * Time.deltaTime);
    }
}
