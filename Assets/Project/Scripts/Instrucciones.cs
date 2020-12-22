using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instrucciones : MonoBehaviour
{
    //public Text TextoVictoria;
    public Image BordeBarra;
    public Image Barra;
    public Image Vida;
    public Text Reloj;
    public Text Puntuacion;
    public Image PanelInstrucciones;
    public Text Title;
    public Text Instruccione;
    public Text text;
    public Image Boton;
    //public TextMesh TextBoton;

    public void Awake() {
        //TextoVictoria.gameObject.SetActive(false);
        BordeBarra.gameObject.SetActive(false);
        Barra.gameObject.SetActive(false);
        Reloj.gameObject.SetActive(false);
        Puntuacion.gameObject.SetActive(false);
        Vida.gameObject.SetActive(false);
        Time.timeScale = 0;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void reanudar(){
        PanelInstrucciones.gameObject.SetActive(false);
        Title.gameObject.SetActive(false);
        Instruccione.gameObject.SetActive(false);
        text.gameObject.SetActive(false);
        Boton.gameObject.SetActive(false);
        //TextBoton.gameObject.SetActive(false);
        BordeBarra.gameObject.SetActive(true);
        Barra.gameObject.SetActive(true);
        Reloj.gameObject.SetActive(true);
        Puntuacion.gameObject.SetActive(true);
        Vida.gameObject.SetActive(true);
       
        Time.timeScale = 1;

    }
}
