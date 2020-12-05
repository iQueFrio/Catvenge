using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlJUMP : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            anim.SetTrigger("Jump");
            //anim.GetComponent<Rigidbody>().AddForce(Vector3.up * 10f * Time.deltaTime);
            //transform.Translate(Vector3.up * 10f * Time.deltaTime);
        }
        else
        {
            anim.ResetTrigger("Jump");
        }
    }
}
