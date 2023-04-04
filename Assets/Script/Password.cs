using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Password : MonoBehaviour
{
    public TMP_InputField inputUser;
    public GameObject disactive;

    public void ControllaTest()
    {
        inputUser.Select();
        string text = inputUser.text;
        if (text == "Lithe123.,")
        {
            disactive.SetActive(false);
        }
    }
}
