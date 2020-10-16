using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ALR_DamagePlayer : ALR_DamageHandler
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected void OnTriggerEnter2D()
   {

       health--;
       invulnTimer = invulnPeriode;
       gameObject.layer = 11;


   }


    protected override void Dying()
    {
        //Debug.Log("PLAYER IS DEAD !");
        StartCoroutine("Die");

    }



    IEnumerator Die()
    {

        animator.SetTrigger("Death");
        //Destroy(gameObject, 0.5f);

        yield return new WaitForSeconds(2);

        //Debug.Log("LET'S MOVE ON !");
        //Debug.Log("MY PV " + health);

        SceneManager.LoadScene("GameOver");

    }









}
