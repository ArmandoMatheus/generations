using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonManager : MonoBehaviour
{
    public static string spawnName, spawnSurname;
    public static int spawnBirthYear, spawnDeathYear;


    public void Start()
    {
        spawnName = "Name";
        spawnSurname = "Last Name";
        spawnBirthYear = 1990;
        spawnDeathYear = 2050;
    }
    public void SetNameInput(string input)
    {
        spawnName = input;
    }
    public void SetSurnameInput(string input)
    {
        spawnSurname = input;
    }
    public void SetBirthYearInput(string input)
    {
        spawnBirthYear = int.Parse(input);
    }
    public void SetDeathYearInput(string input)
    {
        spawnDeathYear = int.Parse(input);
    }
}
