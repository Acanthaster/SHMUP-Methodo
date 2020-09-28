using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEditor.Timeline;
using UnityEngine;

public class ALR_PlayerController : MonoBehaviour
{
    // VARIABLES FOR MOVEMENT
    public float speed ;
    public Animator animator;



    //COMPONENTS FOR MOVEMENT
    private Rigidbody2D rb ;
    private Vector2 moveVelocity ;


    //VARIABLES FOR SHOOT
    public float fireDelay = 0.25f;
    float cooldownTimer = 0f;

    public GameObject bulletPrefab;



    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

    }

    void Update()
    {
        //MOVEMENT
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveVelocity = moveInput.normalized * speed;


        //SHOOT
        cooldownTimer -= Time.fixedDeltaTime;

        Vector3 offset = transform.rotation * new Vector3(0.5f, 0, 0);

        if (Input.GetButton("Fire1") && cooldownTimer <= 0)
        {
            Debug.Log("SHOOT !");
            cooldownTimer = fireDelay;

            Instantiate(bulletPrefab, transform.position + offset, transform.rotation);

        }

    }

    void FixedUpdate()
    {

        //MOVEMENT
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);

        //animator.Play("Bat_Anim_Move");
           
        


        //SHOOT
       

    }






  
}
