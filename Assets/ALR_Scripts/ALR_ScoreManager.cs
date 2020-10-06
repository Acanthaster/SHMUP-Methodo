using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ALR_ScoreManager : MonoBehaviour
{

    //VARIABLES FOR SCORES
    float totalScore;

    public float nmiVertiValue;
    public float nmiStaticValue;
    public float nmiCircleValue;

    private ALR_DamageEnemies dmgEnemy;


    // Start is called before the first frame update
    void Start()
    {
        dmgEnemy = FindObjectOfType<ALR_DamageEnemies>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        AddScore();


    }


    private void AddScore()
    {
        Debug.Log("I DIE !" + dmgEnemy.dead);

        if (dmgEnemy.dead == true)
        {

            Debug.Log("YES YOU ARE DEAD !");

            if (CompareTag("EnemyVertical") == true)
            {
                Debug.Log("TOUCHE !");


                totalScore += nmiVertiValue;

                return;

  

            }

            if (CompareTag("EnemyStatic") == true)
            {

                totalScore += nmiStaticValue;
                return;

            }


            if (CompareTag("EnemyCircleShoot") == true)
            {

                totalScore += nmiCircleValue;
                return;

            }

        }


    }




    public float GetScore()
    {
        Debug.Log("MY SCORE " + totalScore);
        return totalScore;
    }



}
