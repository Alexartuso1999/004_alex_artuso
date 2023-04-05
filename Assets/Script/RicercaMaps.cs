using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RicercaMaps : MonoBehaviour
{
    public TMP_InputField inputUser;
    public GameObject map;
    public GameObject disactive;
    public GameObject error;
    
    public void ControllaTest()
    {
        inputUser.Select();
        string text = inputUser.text;
        if (text == "Cluedo city")
        {
            disactive.SetActive(false);
            map.SetActive(true);
        }
        else
        {
            error.SetActive(true);
        }
    }
}
