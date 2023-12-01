using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject target;
    public float speed;
    private Rigidbody2D rb;
    public Vector3 direction;

    public float destroyGO = 5f;
    private float timer;

    void Start()
    {
        target = GameObject.FindWithTag("Enemy");
        rb = GetComponent<Rigidbody2D>();
        
        direction = target.transform.position - transform.position;
        Vector3 rotation = transform.position - target.transform.position;
        
        rb.velocity = new Vector2(direction.x, direction.y).normalized * speed;
        float rot = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rot + 90);
    }

    // Update is called once per frame
    void Update()
    {
        target = GameObject.FindWithTag("Enemy");

        timer += Time.deltaTime;
        if(timer >= destroyGO)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(this.gameObject);
            Debug.Log("fff");
        }
    }
}
