using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ALR_DamageEnemies : ALR_DamageHandler
{
    public bool dead;

    /*public float valueScore;
    public float nmiVertiValue;
    public float nmiStaticValue;
    public float nmiCircleValue;*/


    // Start is called before the first frame update
    void Start()
    {
        dead = false;

        /*if(gameObject.tag == "EnemyVertical")
        {

            //valueScore = nmiVertiValue;
            //Debug.Log("I AM VERTICAL !");

        }*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    protected override void Dying()
    {
        dead = true;

        animator.SetTrigger("Death");
        Destroy(gameObject, 0.5f);
    }



}
