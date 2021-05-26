using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 20f;
    public float midAirSpeed = 15f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    public bool isGrounded;

    public Transform ceilingCheck;
    public float ceilingDistance = 0.4f;
    public LayerMask ceilingMask;
    public bool ceilingHit;

    public Vector3 velocity;

    public Animator animator;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {

        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        ceilingHit = Physics.CheckSphere(ceilingCheck.position, ceilingDistance, ceilingMask);

        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -3f;
        }

        if(ceilingHit && velocity.y > 0)
        {
            velocity.y = -3f;
        }

        //movement
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        if(isGrounded)
            controller.Move(move * speed * Time.deltaTime);
        else
            controller.Move(move * midAirSpeed * Time.deltaTime); 

        //jumping
        if(Input.GetButton("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);

            //set bool to false when jump
            animator.SetBool("IsMoving", false);
        }

        //gravity force
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

        //walk animation trigger
        if(isGrounded)
        {
            if(Mathf.Pow(z,2) > 0.9f || Mathf.Pow(x,2) > 0.9f)
            animator.SetBool("IsMoving", true);

            else if(Mathf.Pow(z,2) - 0.1f <= 0.9f || Mathf.Pow(x,2) - 0.1f <= 0.9f)
            animator.SetBool("IsMoving", false);
        }
        else
        {
            animator.SetBool("IsMoving", false);
        }
    }
}
