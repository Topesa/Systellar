using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;

public class MouseRotate : MonoBehaviour
{
    [SerializeField] private float rotSpeed = 3f;
    private Vector3 startPosition;
    private Vector3 startRotation;    
    //private float counter = 0;
    private static Timer timer = new(1000);

    private void Start()
    {
        startPosition = transform.position;
        startRotation = transform.localEulerAngles;
    }    

    private void ResetPosition()
    {
        transform.position = startPosition;
        transform.localEulerAngles = startRotation;

        GetComponent<Rotation>().enabled = true;
    }   

    private IEnumerator Wait()
    {
        yield return new WaitForSeconds(3);

        ResetPosition();
    }

    private void OnMouseUp()
    {
        StartCoroutine(Wait());

        //timer.Elapsed += Timer_Elapsed;
        //timer.Enabled = true;        
        //timer.Start();       
    }

    //private void Timer_Elapsed(object sender, ElapsedEventArgs e)
    //{
    //    counter++;

    //    Debug.Log(counter);        
    //}

    private void OnMouseDrag()
    {
        GetComponent<Rotation>().enabled = false;

        float rotX = Input.GetAxis("Mouse X") * rotSpeed;
        float rotY = Input.GetAxis("Mouse Y") * rotSpeed;

        transform.Rotate(Vector3.down, rotX, Space.World);
        transform.Rotate(Vector3.right, rotY, Space.World);       
    }
}
