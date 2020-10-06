using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class HUD : MonoBehaviour
{
    public UnityEngine.UI.Text displayLife;
    public UnityEngine.UI.Text displayScore;
    static public int score;
    public ALR_DamagePlayer ALR_DamageHandler;
    public ALR_ScoreManager scoreManager;

    // Update is called once per frame
    void Update()
    {
        displayScore.text = "Score :" + scoreManager.totalScore.ToString();
      
        if (ALR_DamageHandler.health > 99)
        {
            displayLife.text = "99+";
        }
        else
        {
            displayLife.text = ALR_DamageHandler.health.ToString();
        }
        
    }

    public void GainScore(int scorePlus)
    {
        score += scorePlus;
    }
}
