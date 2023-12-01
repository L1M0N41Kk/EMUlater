using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    public int attackPower;
    public int towerHealth; //optional
  
    public GameObject projectile;
    public Transform pointToSpawnFrom;
    public bool canFire;
    public float timeToShoot;
    private float timer;

    public bool emuInTheArea;

    // Update is called once per frame
    void Update()
    {
        if (!canFire)
        {
            timer += Time.deltaTime;
            if(timer > timeToShoot)
            {
                canFire = true;
                timer = 0;
            }
        }

        if (canFire && emuInTheArea)
        {
            canFire = false;
            Instantiate(projectile, pointToSpawnFrom.position, Quaternion.identity);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            emuInTheArea = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            emuInTheArea = false;
        }
    }
}
