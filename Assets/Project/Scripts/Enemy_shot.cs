using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy_shot : MonoBehaviour
{
    public GameObject player_pos; 
    public GameObject place_one;
    public GameObject place_two;
    public GameObject bala_inicio;
    private float tiempo;
    public GameObject bala;
    public float count = 0;
    public float distance;
    public float point_distance;
    public float speed;
    NavMeshAgent nav;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        //player_pos = GameObject.Find("Cat").transform;
        nav =  GetComponent<NavMeshAgent>();
        nav.SetDestination(place_one.transform.position);
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //nav.SetDestination(player_pos.position);
        if (Mathf.Abs(transform.position.x - place_one.transform.position.x) < point_distance && count == 0){
            nav.SetDestination(place_two.transform.position);
            if(transform.name == "Cyclopes"){anim.SetTrigger("Walk Forward");}
            if(transform.name == "Fiery"){anim.SetTrigger("Walk Forward");}
            if(transform.name == "SlimeRabbit"){anim.SetTrigger("Move");}
        }
        if (Mathf.Abs(transform.position.x - place_two.transform.position.x) < point_distance && count == 0){
            nav.SetDestination(place_one.transform.position);
        }
        if(player_pos != null)
        {
            if (Vector3.Distance(transform.position, player_pos.transform.position) < distance){
                if(transform.name == "Cyclopes"){anim.ResetTrigger("Walk Forward");}
                if(transform.name == "Fiery"){anim.ResetTrigger("Walk Forward");}
                if(transform.name == "SlimeRabbit"){anim.ResetTrigger("Move");}
                nav.speed = 0;
                var rotate = Quaternion.LookRotation(player_pos.transform.position - transform.position);
                transform.rotation = Quaternion.Slerp(transform.rotation, rotate, 10 * Time.deltaTime);
                count = 1;
                transform.position = transform.position;
                tiempo += Time.deltaTime;
                if (tiempo >= 1){
                    //1-Instanciar la BalaPrefab en las posiciones de BalaInicio
                    GameObject BalaTemporal = Instantiate(bala, bala_inicio.transform.position, bala_inicio.transform.rotation) as GameObject;
                    //Obtener Rigidbody para agregar Fuerza. 
                    Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();
                    //Agregar la fuerza a la Bala
                    rb.AddForce(transform.forward * 1000);
                    //Debemos Destruir la bala
                    Destroy(BalaTemporal, 1.5f);
                    tiempo = 0;
                }
            }
            if (Vector3.Distance(transform.position, player_pos.transform.position) > distance){
                count = 0;
                nav.speed = speed;
            }
        }
        //Movimiento
        /*
        if (Vector3.Distance(transform.position, player_pos.position) > distancia_frenado)
        {
            transform.position = Vector3.MoveTowards(transform.position, player_pos.position, speed * Time.deltaTime);
        }
        if (Vector3.Distance(transform.position, player_pos.position) < distancia_retraso)
        {
            transform.position = Vector3.MoveTowards(transform.position, player_pos.position, -speed * Time.deltaTime);
        }
        if (Vector3.Distance(transform.position, player_pos.position) < distancia_frenado && Vector2.Distance(transform.position, player_pos.position) > distancia_retraso)
        {
            transform.position = transform.position;
        }
        */
    }
}
