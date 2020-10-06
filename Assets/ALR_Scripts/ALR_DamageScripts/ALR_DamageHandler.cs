using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ALR_DamageHandler : MonoBehaviour
{
    public int health = 1;
    protected float invulnTimer;
    public float invulnPeriode;
    int correctLayer;
    private bool dead = false;

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
        if (invulnTimer <= 0)
        {

            gameObject.layer = correctLayer;

        }

        if (health <= 0 && dead == false)
        {
            dead = true;
            //Debug.Log("JE SUIS EN VIE " + health);
            Dying();
        }


    }


    protected virtual void OnTriggerEnter2D()
    {
        health--;
    }



    protected virtual void Dying()
    {

    }



}
