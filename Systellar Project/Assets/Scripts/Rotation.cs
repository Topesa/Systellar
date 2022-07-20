using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] private Vector3 rotation;
    [SerializeField] private float speed;

    private void LateUpdate()
    {
        transform.Rotate(speed * Time.deltaTime * rotation);
    }
}
