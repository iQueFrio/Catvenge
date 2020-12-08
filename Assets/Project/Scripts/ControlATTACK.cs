﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlATTACK : MonoBehaviour
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
        if (Input.GetKey(KeyCode.C) || Input.GetKey(KeyCode.Joystick1Button0))
        {
            anim.SetTrigger("Attack");
        }
        else
        {
            anim.ResetTrigger("Attack");
        }
    }
}
