using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VidaPlayer : MonoBehaviour
{
    public float vida = 100;
    public Image barraDeVida;
    public Text TextoPerdido;

    public Text LimiteTiempo;
    float tiempo;

    public void Awake() {
        TextoPerdido.gameObject.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        tiempo = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        vida = Mathf.Clamp(vida, 0, 100);
        barraDeVida.fillAmount = vida/100;
        //Lo intente asi pero no cargo bien el menu quiza tu si lo veas bien, si no probar otra opcion 
        if(vida == 0 || LimiteTiempo.text.Equals("03:00") ){
            TextoPerdido.text = "Lo siento, ¡Has Perdido!";
            TextoPerdido.gameObject.SetActive(true);
            tiempo += Time.deltaTime; 
            
            if(tiempo >= 4){
                ConsultasSQL sql = new ConsultasSQL(); 
                CameraSettings camera = GameObject.Find("LeftEye").GetComponent<CameraSettings>();
                string paciente = camera.idPaciente;
                string especialista = camera.idEspecialista;
                //Debug.Log("Paciente " + paciente + " Especialista "+ especialista);
                string duracion = LimiteTiempo.text.ToString();
                sql.insertTratamiento("Manejo de Contrastes","10",duracion,paciente,especialista);
                //Debug.Log(paciente + " " + especialista + " " + LimiteTiempo.text);
                SceneManager.LoadScene("Menu");
            }
        }
        
    }
}
