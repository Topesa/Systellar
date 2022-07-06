using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ? 2017 TheFlyingKeyboard and released under MIT License
// theflyingkeyboard.net

public class MouseZoom : MonoBehaviour
{
    public Transform target;
    public float speed;

    void Update()
    {
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            float scroll = Input.GetAxis("Mouse ScrollWheel");

            transform.LookAt(target);
            transform.Translate(0, 0, scroll * speed, Space.Self);


        }

        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {

            float scroll = Input.GetAxis("Mouse ScrollWheel");
            transform.LookAt(target);
            transform.Translate(0, 0, scroll * speed, Space.Self);
        }

    }
}