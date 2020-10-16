using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateEnemy : MonoBehaviour
{
    EnemyVertical enemyV;
    EnemyStatic enemyS;
    EnemyCircleShoot enemyC;
    // Start is called before the first frame update
    void Start()
    {
        enemyC = GetComponent<EnemyCircleShoot>();
        enemyS = GetComponent<EnemyStatic>();
        enemyV = GetComponent<EnemyVertical>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    protected void OnTriggerEnter2D(Collider2D collider)
    { 
            if (collider.CompareTag("Camera"))
            {
                if (this.CompareTag("EnemyVertical"))
                {
                    enemyV.enabled = true;
                }
                else if (this.CompareTag("EnemyCircleShoot"))
                {
                    enemyC.enabled = true;

                }
                else if (this.CompareTag("EnemyStatic"))
                {
                    enemyS.enabled = true;
                }

            }
       
    }
}
