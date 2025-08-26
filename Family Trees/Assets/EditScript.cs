using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EditScript : MonoBehaviour
{
    public static bool editor;
    public static bool changeMade;

    public GameObject person;


    void Start()
    {
        editor = false;
    }

    public void SetEdit()
    {
        if (!editor)
        {
            editor = true;
        }
        if (editor)
        {
            editor = false;
        }
    }

    public static void Change()
    {
        if(changeMade == true)
        {
            changeMade = false;
        }
        else
        {
            changeMade = true;
        }
    }

    public void AddPiece()
    {
        Instantiate(person, transform.position, transform.rotation);
    }
}
