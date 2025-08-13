using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PersonScript : MonoBehaviour
{
    public string firstName;
    public string lastName;
    public int age;
    public int birthYear;
    public int deathYear;
    public bool isDead;
    int yearCheck;

    public TMP_Text ageText;

    private void Start()
    {
        yearCheck = CurrentYear.currentYear;
    }

    void Update()
    {
        if(yearCheck != CurrentYear.currentYear)
        {
            SetAge();
        }
    }

    public void SetAge()
    {
        age =  CurrentYear.currentYear - birthYear;
        ageText.text = age.ToString();
        yearCheck = CurrentYear.currentYear;

    }

    public void DeathAge()
    {
        age = deathYear - birthYear;
    }
}
