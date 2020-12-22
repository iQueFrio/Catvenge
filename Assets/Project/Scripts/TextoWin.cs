using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextoWin : MonoBehaviour
{
    public Text TextoVictoria;
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    public GameObject enemy4;
    public GameObject enemy5;
    public GameObject enemy6;
    public GameObject enemy7;
    public GameObject enemy8;
    float tiempo;
    // Start is called before the first frame update
    void Start()
    {
        tiempo = 0;
    }

    public void Awake() {
        TextoVictoria.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(enemy1 == null && enemy2 == null && enemy3 == null && enemy4 == null && enemy5 == null && enemy6 == null && enemy7 == null && enemy8 == null)
        //if (enemy4 == null)
        {
            TextoVictoria.text = "¡Has Ganado!";
            TextoVictoria.gameObject.SetActive(true);
            tiempo += Time.deltaTime; 
            if(tiempo >= 7){
                SceneManager.LoadScene("Menu");
            }
        }
    }
}
