using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BotonLoad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.JoystickButton0) || Input.GetKey(KeyCode.W)) 
        {
            SceneManager.LoadScene("Game");
        }
        if (Input.GetKey(KeyCode.JoystickButton2) || Input.GetKey(KeyCode.S))
        {
            Debug.Log("Saliendo de la app");
            Application.Quit();
        }
    }
}
