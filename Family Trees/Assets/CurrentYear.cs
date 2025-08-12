using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentYear : MonoBehaviour
{
    public int currentYear;

    public void YearAdd()
    {
        currentYear++;
    }

    public void YearRem()
    {
        currentYear--;
    }
}
