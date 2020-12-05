using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlidle2 : MonoBehaviour
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
        if (Input.GetKey(KeyCode.LeftControl))
        {
            anim.SetTrigger("Idle2");
        }
        else
        {
            anim.ResetTrigger("Idle2");
        }
    }
}
