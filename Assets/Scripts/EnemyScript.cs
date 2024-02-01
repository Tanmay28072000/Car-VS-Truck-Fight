using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    
    [SerializeField] public float strength;
    Rigidbody2D rb2;
    private void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        rb2.velocity = Vector2.down * strength;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("EnemyCollider"))
        {
            Destroy(this.gameObject);
        }
        if (collision.gameObject.CompareTag("PlayerCollider"))
        {
            GameManager.gameManager.PlayerHealth -= 5;
            Destroy(this.gameObject);
        }

    }
}
