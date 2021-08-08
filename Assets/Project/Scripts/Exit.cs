using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    public void exit()
    {
        Application.Quit();
        Debug.Log("Salio de la APP");
    }
}
