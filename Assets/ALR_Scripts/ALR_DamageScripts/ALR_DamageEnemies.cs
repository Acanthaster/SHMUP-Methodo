using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ALR_DamageEnemies : ALR_DamageHandler
{
    //public bool dead;

    private ALR_ScoreManager scoreManager;


    // Start is called before the first frame update
    void Start()
    {
        //dead = false;
        scoreManager = FindObjectOfType<ALR_ScoreManager>();
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    protected override void Dying()
    {
        //dead = true;

        switch(this.gameObject.tag)
        {
            case "EnemyVertical" :
                scoreManager.AddScore(scoreManager.nmiVertiValue);
                break;
            case "EnemyStatic":
                scoreManager.AddScore(scoreManager.nmiStaticValue);
                break;
            case "EnemyCircleShoot":
                scoreManager.AddScore(scoreManager.nmiCircleValue);
                break;
            default:
                break;
        }

        animator.SetTrigger("Death");
        Destroy(gameObject, 0.5f);
    }



}
