using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegeneraVida : MonoBehaviour
{
    VidaPlayer playerVida;
    public int cantidad;
    public float lifetime;
    float currentLifeTime;
    // Start is called before the first frame update
    void Start()
    {
        playerVida = GameObject.FindWithTag("Cat").GetComponent<VidaPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other) {
        if(playerVida != null){
            if(other.tag == "Cat"){
                currentLifeTime += Time.deltaTime;
                if(currentLifeTime > lifetime){
                    playerVida.vida += cantidad;
                    currentLifeTime = 0.0f;
                }
            }
        }
    }
}
