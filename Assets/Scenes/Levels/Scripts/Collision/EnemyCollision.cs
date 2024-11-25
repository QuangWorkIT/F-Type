using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class EnemyCollision : MonoBehaviour
{
    // Start is called before the first frame update
    public float heal = 100f;
    void Start()
    {
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("bullet"))
        {
            TakeDamage();
            Destroy(collision.gameObject); // Destroy the bullet
        }
    }
    private void TakeDamage()
    {
        heal -= 50; 
        Debug.Log("heal:" + heal);
        if (heal <= 0)
        {
            Die();
        }

    }

    private void Die()
    {
        Destroy(gameObject);
        Score scoreScript = FindObjectOfType<Score>();
        if (scoreScript != null)
        {
            scoreScript.UpdateScore(1);
        }

        Debug.Log("Object destroy");
    }

}