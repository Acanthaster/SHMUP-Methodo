using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAimBullet : MonoBehaviour
{
    public float Speed;

    Rigidbody2D rb;
    ALR_PlayerController target;
    Vector2 moveDirection;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindObjectOfType<ALR_PlayerController>();
        moveDirection = (target.transform.position - transform.position).normalized * Speed;
        rb.velocity = new Vector2(moveDirection.x, moveDirection.y);
        Destroy(gameObject, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name.Equals("Player"))
        {
            Debug.Log("Hit!");
            Destroy(gameObject);
        }
    }
}
