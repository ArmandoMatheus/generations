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

    bool canEdit;

    public TMP_Text ageText;
    public TMP_Text firstNameText;
    public TMP_Text lastNameText;

    private void Start()
    {
        yearCheck = CurrentYear.currentYear;
        firstNameText.text = PersonManager.spawnName.ToString();
        lastNameText.text = PersonManager.spawnSurname.ToString();
        birthYear = PersonManager.spawnBirthYear;
        deathYear = PersonManager.spawnDeathYear;
    }

    void Update()
    {
        if(yearCheck != CurrentYear.currentYear)
        {
            if(CurrentYear.currentYear >= deathYear)
            {
                DeathAge();
            }
            if(CurrentYear.currentYear < deathYear)
            {
                SetAge();
            }
        }

        if(EditScript.editor == true)
        {
            IsEditing();
        }
        if(EditScript.editor == false)
        {
            NotEditing();
        }
    }

    public void SetAge()
    {
        age = CurrentYear.currentYear - birthYear;
        ageText.text = age.ToString();
        yearCheck = CurrentYear.currentYear;
    }

    public void SetInfo()
    {
        firstNameText.text = firstName.ToString();
        lastNameText.text = lastName.ToString();
    }

    public void DeathAge()
    {
        age = deathYear - birthYear;
    }

    public void IsEditing()
    {

    }
    public void NotEditing()
    {

    }

}
