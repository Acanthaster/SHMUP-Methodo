using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStatic : MonoBehaviour
{
    [SerializeField]
    GameObject bullet;

    public float fireRate;
    Vector2 spawnBullet;





    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Shoot");
    }

    // Update is called once per frame
    void Update()
    {
        spawnBullet = new Vector2(transform.position.x - 1, transform.position.y);
    }

    IEnumerator Shoot()
    {
        Instantiate(bullet, spawnBullet, Quaternion.identity);
        yield return new WaitForSeconds(fireRate);
        StartCoroutine("Shoot");
    }
}
