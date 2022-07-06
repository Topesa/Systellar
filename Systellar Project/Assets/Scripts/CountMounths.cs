using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountMounths : MonoBehaviour
{
    private float timer = 0;
    private float monthDisplay;
    private float yearDisplay;
    public TMP_Text displayText;

    private void Update()
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
