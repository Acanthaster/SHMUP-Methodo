using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyVertical : MonoBehaviour
{
    [SerializeField]
    GameObject bullet;

    Rigidbody2D rb;

    public float fireRate;
    public float speed;
    Vector2 spawnBullet;

    public bool up;
    public bool down;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        up = false;
        down = false;
        StartCoroutine("Shoot");
        StartCoroutine("Down");        
    }

    // Update is called once per frame
    void Update()
    {
        spawnBullet = new Vector2(transform.position.x - 1, transform.position.y);
        if (up == true)
        {
            rb.velocity = Vector2.up*speed;
        }
        if (down == true)
        {
            rb.velocity = Vector2.down*speed;
        }
    }

    IEnumerator Shoot()
    {
        Instantiate(bullet, spawnBullet, Quaternion.identity);
        yield return new WaitForSeconds(fireRate);
        StartCoroutine("Shoot");
    }
    IEnumerator Up()
    {
        up = true;
        down = false;
        yield return new WaitForSeconds(2);
        StartCoroutine("Down");
    }
    IEnumerator Down()
    {
        up = false;
        down = true;
        yield return new WaitForSeconds(2);
        StartCoroutine("Up");
    }
}
