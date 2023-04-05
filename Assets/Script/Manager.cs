using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject activeGameObject;
    public GameObject disactiveGameObject;

    public void ActivateObject()
    {
        if (activeGameObject.activeSelf != true)
        {
            activeGameObject.SetActive(true);
        }
        else
        {
            activeGameObject.SetActive(false);
        }
    }

    public void DisactiveObject()
    {
        if (disactiveGameObject.activeSelf == true)
        {
            disactiveGameObject.SetActive(false);
        }
    }
}
