using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ALR_BulletMoveForward : MonoBehaviour
{
    public float speed;
    public float bulletTimer = 5f;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        //BULLET MOVEMENT
        Vector3 bulletpos = transform.position;
        Vector3 velocity = new Vector3(speed * Time.fixedDeltaTime, 0, 0);

        bulletpos += transform.rotation * velocity;
        transform.position = bulletpos;


        //BULLET TIMED DESTRUCTION
        bulletTimer -= Time.fixedDeltaTime;

        if (bulletTimer <= 0)
        {
            Destroy(gameObject);
        }



    }
}
