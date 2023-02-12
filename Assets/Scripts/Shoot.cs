using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
   
    public Transform tip;
    public Camera fpsCam;
   
    public Animator anim;

    public GameObject fireBall;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            Vector3 rayOrigin = fpsCam.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0));
            RaycastHit hit;
            anim.SetBool("fire", true);
            if (Physics.Raycast(rayOrigin, fpsCam.transform.forward, out hit))
            {
                
            }
        }
        else
        {
            anim.SetBool("fire", false);
            anim.SetBool("hold", false);
        }
        if (Input.GetButton("Fire2"))
        {
            anim.SetBool("light", true);
        }
        else
        {
            anim.SetBool("light", false);
            
        }
    }
    void FireBall()
    {
        Instantiate(fireBall, tip.transform.position, fpsCam.transform.rotation);
    }
    void Hold()
    {
        anim.SetBool("hold", true);
    }
    
}
