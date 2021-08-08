using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public string[] eye;
    void Start()
    {
        ConsultasSQL sql = new ConsultasSQL();
        eye = sql.getAngleEyes();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
