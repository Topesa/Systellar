using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitSimulation : MonoBehaviour
{
    readonly float G = 100f;    
 
    GameObject[] planets;

    void Start()
    {
        planets = GameObject.FindGameObjectsWithTag("Planet");

        Velocity();
    }

    void Gravity()
    {
        foreach (GameObject x in planets)
        {
            foreach (GameObject y in planets)
            {
                if (!x.Equals(y))
                {
                    float m1 = x.GetComponent<Rigidbody>().mass;
                    float m2 = y.GetComponent<Rigidbody>().mass;
                    float r = Vector3.Distance(x.transform.position, y.transform.position);

                    x.GetComponent<Rigidbody>().AddForce((y.transform.position - x.transform.position).normalized * (G * (m1 * m2) / Mathf.Pow(r, 2)));
                }
            }
        }
    }

    void Velocity()
    {
        foreach (GameObject x in planets)
        {
            foreach (GameObject y in planets)
            {
                if (!x.Equals(y))
                {
                    float m2 = y.GetComponent<Rigidbody>().mass;
                    float r = Vector3.Distance(x.transform.position, y.transform.position);

                    x.transform.LookAt(y.transform);

                    x.GetComponent<Rigidbody>().velocity += x.transform.right * Mathf.Sqrt((G * m2) / r);
                }
            }
        }
    }

    void FixedUpdate()
    {
        Gravity();
    }
}
