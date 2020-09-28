﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ALR_DamageHandler : MonoBehaviour
{

    public int health = 1;
    float invulnTimer;
    public float invulnPeriode;
    int correctLayer;

    public Animator animator;




    // Start is called before the first frame update
    void Start()
    {
        correctLayer = gameObject.layer;

        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        invulnTimer -= Time.fixedDeltaTime;
        if(invulnTimer <= 0)
        {

            gameObject.layer = correctLayer;

        }

        if (health <= 0)
        {
            Die();
        }


    }

    void OnTriggerEnter2D()
    {
       

            health--;
            Debug.Log("OUTCH" + health);

            invulnTimer = invulnPeriode;
            gameObject.layer = 11;
        

    }



    void Die()
    {
        animator.SetTrigger("Death");
        Destroy(gameObject, 2f);
        

    }




}
