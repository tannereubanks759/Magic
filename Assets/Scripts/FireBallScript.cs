using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallScript : MonoBehaviour
{
    public Rigidbody rb;
    void Start()
    {
        rb.velocity = transform.TransformDirection(new Vector3(0, 0, 15f));
    }
    // Update is called once per frame
    void Update()
    {

    }


}