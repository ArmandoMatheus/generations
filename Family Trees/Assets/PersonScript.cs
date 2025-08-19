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

    public GameObject childSpawn;
    public GameObject parentSpawn;



    private void Start()
    {
        yearCheck = CurrentYear.currentYear;
        firstNameText.text = firstName.ToString();
        lastNameText.text = lastName.ToString();
        childSpawn.SetActive(false);
        parentSpawn.SetActive(false);
    }

    void Update()
    {
        if(yearCheck != CurrentYear.currentYear && isDead==false)
        {
            SetAge();
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

    public void DeathAge()
    {
       
        age = deathYear - birthYear;
    }

    public void IsEditing()
    {
        childSpawn.SetActive(true);
        parentSpawn.SetActive(true);
    }
    public void NotEditing()
    {
        childSpawn.SetActive(false);
        parentSpawn.SetActive(false);
    }

}
