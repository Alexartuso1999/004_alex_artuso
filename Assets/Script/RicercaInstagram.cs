using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RicercaInstagram : MonoBehaviour
{
    public TMP_InputField inputUser;
    public GameObject msScarlett;
    public GameObject revGreen;
    public GameObject plum;
    public GameObject disactive;
    public GameObject error;

    public void ControllaTest()
    {
        inputUser.Select();
        string text = inputUser.text;
        if (text == "Ms Scarlett")
        {
            disactive.SetActive(false);
            msScarlett.SetActive(true);
        }
        else if (text == "Green")
        {
            disactive.SetActive(false);
            revGreen.SetActive(true);
        }
        else if (text == "Plum")
        {
            disactive.SetActive(false);
            plum.SetActive(true);
        }
        else
        {
            error.SetActive(true);
        }
    }
}
