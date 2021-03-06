using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CapsIfActive : MonoBehaviour
{
    [SerializeField] private GameObject planetPanel;

    [SerializeField] private TMP_Text planetText;

    private void Update()
    {
        Caps();
    }

    private void Caps()
    {
        if (planetPanel.activeInHierarchy)
        {
            planetText.fontStyle = FontStyles.UpperCase;
        }
        else
        {
            planetText.fontStyle = FontStyles.Normal;
        }
    }
}
