using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManipuladorVida : MonoBehaviour
{
    VidaPlayer playerVida;
    public int cantidad;
    public string nombre_bala;
    // Start is called before the first frame update
    void Start()
    {
        playerVida = GameObject.FindWithTag("Cat").GetComponent<VidaPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other) {
        if (playerVida != null){
            if (other.collider.gameObject.name == nombre_bala)
            {
                playerVida.vida += cantidad;
            }
        }
    }

}
