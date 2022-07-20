using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableDisableText : MonoBehaviour
{
    [SerializeField] private GameObject textPanel;

    public void EnableDisableTextPanel()
    {
        if (textPanel.activeInHierarchy)
        {
            textPanel.SetActive(false);
        }
        else
        {
            textPanel.SetActive(true);
        }
    }
}
