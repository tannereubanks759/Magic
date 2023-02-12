using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    public Rigidbody rb;
    void Start()
    {
        rb.velocity = transform.TransformDirection(new Vector3(0, 0, 30f));
    }
    // Update is called once per frame
    void Update()
    {
        
    }


}
