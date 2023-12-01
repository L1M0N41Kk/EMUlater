using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Farme : MonoBehaviour
{
    public int farmeHealth = 10;
    public int currentHealth;

    public TMPro.TextMeshPro counter;
    public TMPro.TextMeshPro counterTime;

    public string loseScene;
    public string winScene;

    public float timeDuration = 120f;
    private float timer = 0f;

    void Start()
    {
        currentHealth = farmeHealth;
    }

    // Update is called once per frame
    void Update()
    {
        counter.text = "Health Farme: " + currentHealth;

        timer += Time.deltaTime;
        if (timer >= timeDuration)
        {
            SceneManager.LoadScene(winScene);
        }

        int remainingSeconds = Mathf.RoundToInt(timeDuration - timer);
        counterTime.text = " Time left: " + remainingSeconds.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Enemy"))
        {
            TakeDamage(1);
        }
    }

    void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;
        if (currentHealth == 0)
        {
            Die();
        }

    }

    void Die()
    {
        SceneManager.LoadScene(loseScene);
    }
}
