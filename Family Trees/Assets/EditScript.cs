using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EditScript : MonoBehaviour
{
    public static bool editor;
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
}
