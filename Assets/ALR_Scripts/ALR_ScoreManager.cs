using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ALR_ScoreManager : MonoBehaviour
{

    //VARIABLES FOR SCORES
    public float totalScore = 0;
    public float nmiVertiValue;
    public float nmiStaticValue;
    public float nmiCircleValue;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {


    }


    public void AddScore(float enemyValue)
    {
        Debug.Log("Gain !" + enemyValue);
        totalScore += enemyValue;
        Debug.Log("I DIE !" + totalScore);
    }




    /*public float GetScore()
    {
        Debug.Log("MY SCORE " + totalScore);
        return totalScore;
    }*/



}
