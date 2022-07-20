using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountMounths : MonoBehaviour
{
    [SerializeField] private TMP_Text displayText;

    private float timer = 0;
    private float monthDisplay;
    private float yearDisplay;

    private void Update()
    {
        DisplayMonths();
    }

    private void DisplayMonths()
    {
        timer += Time.deltaTime;

        if (timer >= 6)
        {
            monthDisplay++;
            timer = 0;
        }

        if (monthDisplay >= 12)
        {
            yearDisplay++;
            monthDisplay = 0;
        }

        displayText.text = "<b>Time</b>\n(Earths)\n\nMonth(s): " + monthDisplay.ToString() + "\n" + "Year(s): " + yearDisplay.ToString();
    }
}
