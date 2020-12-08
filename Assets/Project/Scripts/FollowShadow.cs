using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowShadow : MonoBehaviour
{
    public GameObject follower; 
    // Start is called before the first frame update
    void Start()
    {
        transform.position = follower.transform.position;
        transform.rotation = follower.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (follower != null)
        {
            transform.position = follower.transform.position;
            transform.rotation = follower.transform.rotation;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
