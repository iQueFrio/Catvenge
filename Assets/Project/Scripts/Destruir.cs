using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruir : MonoBehaviour
{
    public GameObject explosion;
    public GameObject fire;
    int count = 1;
    public int impactos_muerte;
    public string nombre_bala;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other) {
        if (other.collider.gameObject.name == nombre_bala && count >= impactos_muerte)
        {
            Destroy(gameObject);
            GameObject exp =  Instantiate(explosion, transform.position, transform.rotation);
            Destroy(exp, 2f);
            Instantiate(fire, transform.position, transform.rotation);
        }
        else
            count += 1;
    }
}
