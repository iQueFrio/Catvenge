using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VidaPlayer : MonoBehaviour
{
    public float vida = 100;
    public Image barraDeVida;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        vida = Mathf.Clamp(vida, 0, 100);
        barraDeVida.fillAmount = vida/100;
        /*
        //Lo intente asi pero no cargo bien el menu quiza otra forma o ver que paso con esta opcion 
        if(vida == 0){
            SceneManager.LoadScene("Menu");
        }
        */
    }
}
