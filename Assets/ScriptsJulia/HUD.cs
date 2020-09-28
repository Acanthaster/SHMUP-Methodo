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
    public ALR_DamageHandler ALR_DamageHandler;

    // Update is called once per frame
    void Update()
    {
        displayScore.text = "Score :" + score.ToString();
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
