using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlRUN : MonoBehaviour
{
    Animator anim;
    public float speedrun = 5f;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.JoystickButton5) )
        {
            anim.SetTrigger("Run");
            transform.Translate(Vector3.forward * speedrun * Time.deltaTime);
        }
        else
        {
            anim.ResetTrigger("Run");
        }
    }
}
