using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableDisable : MonoBehaviour
{
    [SerializeField] private GameObject panel;

    [SerializeField] private GameObject panel2;

    [SerializeField] private GameObject panel3;

    public void EnableDisablePlanets()
    {
        if (panel.activeInHierarchy)
        {
            panel.SetActive(false);
        }
        else
        {
            panel.SetActive(true);
        }
    }
    public void EnableDisableControls()
    {
        if (panel2.activeInHierarchy)
        {
            panel2.SetActive(false);
        }
        else
        {
            panel2.SetActive(true);
        }
    } 
    public void EnableDisableDistanceInfo()
    {
        if (panel3.activeInHierarchy)
        {
            panel3.SetActive(false);
        }
        else
        {
            panel3.SetActive(true);
        }
    }

}
