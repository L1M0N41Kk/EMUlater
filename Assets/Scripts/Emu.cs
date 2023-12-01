using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emu : MonoBehaviour
{
    public int health = 5;

    void Start()
    {
        
    }

    void Update()
    {
        if(health <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Bullet 1(Clone)")
        {
            health--;
            Debug.Log("fff");
        }
    }
}
