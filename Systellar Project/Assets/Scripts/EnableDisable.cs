using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableDisable : MonoBehaviour
{
    [SerializeField] private GameObject planetsPanel;

    [SerializeField] private GameObject controlsPanel;

    [SerializeField] private GameObject distancePanel;

    public void EnableDisablePlanets()
    {
        if (planetsPanel.activeInHierarchy)
        {
            planetsPanel.SetActive(false);
        }
        else
        {
            planetsPanel.SetActive(true);
        }
    }

    public void EnableDisableControls()
    {
        if (controlsPanel.activeInHierarchy)
        {
            controlsPanel.SetActive(false);
        }
        else
        {
            controlsPanel.SetActive(true);
        }
    }

    public void EnableDisableDistanceInfo()
    {
        if (distancePanel.activeInHierarchy)
        {
            distancePanel.SetActive(false);
        }
        else
        {
            distancePanel.SetActive(true);
        }
    }

}
