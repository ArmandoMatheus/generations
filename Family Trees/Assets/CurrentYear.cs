using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CurrentYear : MonoBehaviour
{
    public static int currentYear;
    public TMP_Text yearText;
    public void Start()
    {
        currentYear = 2010;
    }

    public void YearAdd()
    {
        currentYear++;
        yearText.text = currentYear.ToString();
    }

    public void YearRem()
    {
        currentYear--;
        yearText.text = currentYear.ToString();
    }
}
