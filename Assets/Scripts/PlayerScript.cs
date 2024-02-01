using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
 
    Rigidbody2D rb1;
    [SerializeField] public float strength;

    private void Start()
    {
        rb1 = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
      
        rb1.velocity = Vector2.up * strength;

        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("EnemyCollider"))
        {
            GameManager.gameManager.AIHealth -= 5;
            Destroy(this.gameObject);
        }
        if (collision.gameObject.CompareTag("PlayerCollider"))
        {
            Destroy(this.gameObject);
        }

    }
}
