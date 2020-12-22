using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Reloj : MonoBehaviour
{
    [Tooltip("Tiempo inicial en segundos")]
    public int tiempoInicial;
    [Tooltip("Escala del tiempo del reloj")]
    [Range(-10.0f,10.0f)]
    public float escalaDeTiempo = 1;

    private Text myText;
    private float TiempoFrameConTiempoScale = 0f;
    private float tiempoMostrarEnSegundos = 0F;
    private float escalaDeTiempoPausar, escalaDeTiempoInicial;
    private bool EstaPausado = false;

    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    public GameObject enemy4;
    public GameObject enemy5;
    public GameObject enemy6;
    public GameObject enemy7;
    public GameObject enemy8;

    public GameObject life;

    // Start is called before the first frame update
    void Start()
    {
        //Escala de Tiempo Original
        escalaDeTiempoInicial = escalaDeTiempo;
        myText = GetComponent<Text>();
        tiempoMostrarEnSegundos = tiempoInicial;
        ActualizarReloj(tiempoInicial);
    }

    // Update is called once per frame
    void Update()
    {
        TiempoFrameConTiempoScale = Time.deltaTime * escalaDeTiempo;
        tiempoMostrarEnSegundos += TiempoFrameConTiempoScale;
        ActualizarReloj(tiempoMostrarEnSegundos);
    }

    public void ActualizarReloj(float tiempoEnSegundos)
    {
      float vida = life.GetComponent<VidaPlayer>().vida;
    
      if(tiempoEnSegundos < 181f){
        if(enemy1 != null || enemy2 != null || enemy3 != null || enemy4 != null || enemy5 != null || enemy6 != null || enemy7 != null || enemy8 != null){
          if(vida != 0f){
            int minutos = 0;
            int segundos = 0;
            // int milisegundos = 0;
            string textoDelReloj;

            if (tiempoEnSegundos < 0) tiempoEnSegundos = 0;

            minutos = (int)tiempoEnSegundos / 60;
            segundos = (int)tiempoEnSegundos % 60;
            //milisegundos = (int)tiempoEnSegundos / 1000;

            textoDelReloj = minutos.ToString("00") + ":" + segundos.ToString("00"); //+ ":" + milisegundos.ToString("00");
            myText.text = textoDelReloj;
          }
        }
      }  
    }
}
