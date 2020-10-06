using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ALR_DamageHandlerPlayer : MonoBehaviour
{

    public int playerHealth = 1;
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

        if (playerHealth <= 0)
        {
            Debug.Log("JE SUIS EN VIE " + playerHealth);
            Dying();
        }


    }

    void OnTriggerEnter2D()
    {


            playerHealth--;
            //Debug.Log("OUTCH" + health);

            invulnTimer = invulnPeriode;
            gameObject.layer = 11;
        

    }


    private void Dying()
    {
        Debug.Log("PLAYER IS DEAD !");
        StartCoroutine("Die");

    }



    IEnumerator Die()
    {

        animator.SetTrigger("Death");
        //Destroy(gameObject, 0.5f);
       
        yield return new WaitForSeconds(2);

        Debug.Log("LET'S MOVE ON !");
        Debug.Log("MY PV " + playerHealth);

        SceneManager.LoadScene("GameOver");

    }




}
