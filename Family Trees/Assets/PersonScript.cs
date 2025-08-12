using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonScript : MonoBehaviour
{
    public string firstName;
    public string lastName;
    public int age;
    public int birthYear;
    public int deathYear;
    public bool isAlive;
    public CurrentYear current;

    void Start()
    {
        
    }

    public void CurrentAge()
    {
        age =  current.currentYear - birthYear;
    }

    public void DeathAge()
    {
        age = deathYear - birthYear;
    }
}
