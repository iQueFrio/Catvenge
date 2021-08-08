using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlWALK : MonoBehaviour
{
    Animator anim;
    public float speedwalk = 5f;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            anim.SetTrigger("Walk");
            transform.Translate(Vector3.forward * speedwalk * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.JoystickButton2))
        {
            anim.SetTrigger("Walk");
            transform.Translate(Vector3.back * speedwalk * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.JoystickButton3))
        {
            anim.SetTrigger("Walk");
            transform.Translate(Vector3.left * speedwalk * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.JoystickButton1))
        {
            anim.SetTrigger("Walk");
            transform.Translate(Vector3.right * speedwalk * Time.deltaTime);
        }
        else
        {
            anim.ResetTrigger("Walk");
        }
    }
}
