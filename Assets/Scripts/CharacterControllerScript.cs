using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControllerScript : MonoBehaviour
{
    //player
    public float height;

    //movement
    private float horizontal;
    private float vertical;
    private Vector3 moveDirection;
    public float moveSpeed;
    public CharacterController controller;

    //look variables
    public float sensX;
    public float sensY;
    public Camera cam;
    float mouseX;
    float mouseY;
    float multiplier = .01f;
    float xRotation;
    float yRotation;

    //jumping
    private bool isGrounded;
    public KeyCode jumpKey = KeyCode.Space;
    public float jumpForce;

    //casting
    public Animator anim;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        //movement
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
        moveDirection = transform.forward * vertical + transform.right * horizontal;
        controller.SimpleMove(moveDirection.normalized * moveSpeed);

        //looking
        mouseX = Input.GetAxisRaw("Mouse X");
        mouseY = Input.GetAxisRaw("Mouse Y");
        yRotation += mouseX * sensX * multiplier;
        xRotation -= mouseY * sensY * multiplier;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        cam.transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
        transform.rotation = Quaternion.Euler(0, yRotation, 0);

        
    }
    private void FixedUpdate()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "ground")
        {
            isGrounded = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            isGrounded = false;
        }
    }
}
