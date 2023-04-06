using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Endgame : MonoBehaviour
{
    public TMP_InputField inputUser;
    public GameObject endgame;
    public GameObject error;

    public void ControllaTest()
    {
        inputUser.Select();
        string text = inputUser.text;
        if (text == "C-5, K-73, S-23")
        {
            endgame.SetActive(true);
        }
        else
        {
            error.SetActive(true);
        }
    }
}
