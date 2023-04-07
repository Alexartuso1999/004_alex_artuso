using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CercaTarga : MonoBehaviour
{
    public TMP_InputField inputUser;
    public GameObject active;
    public GameObject disactive;
    public GameObject error;

    public void ControllaTest()
    {
        inputUser.Select();
        string text = inputUser.text;
        if (text == "AH425")
        {
            active.SetActive(true);
            disactive.SetActive(false);
        }
        else
        {
            error.SetActive(true);
        }
    }
}
