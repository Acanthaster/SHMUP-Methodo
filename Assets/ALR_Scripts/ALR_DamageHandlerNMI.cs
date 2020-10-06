using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ALR_DamageHandlerNMI : MonoBehaviour
{

    public int enemyHealth = 1;
    float invulnTimer;
    public float invulnPeriode;
    int correctLayer;
    public bool dead;

    public Animator animator;




    // Start is called before the first frame update
    void Start()
    {
        dead = false;
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

        if (enemyHealth <= 0)
        {
            dead = true;
            EnemyDie();
           
        }


    }

    void OnTriggerEnter2D()
    {


            enemyHealth--;
            //Debug.Log("OUTCH" + health);

            invulnTimer = invulnPeriode;
            gameObject.layer = 11;
        

    }



    private void EnemyDie()
    {

        animator.SetTrigger("Death");
        Destroy(gameObject, 0.5f);
       

    }




}
