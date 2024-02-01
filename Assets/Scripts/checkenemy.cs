using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkenemy : MonoBehaviour
{
    void Update()
    {
       // GameManager.gameManager.notspawn2 = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy/10"))
        {
            GameManager.gameManager.notspawn2 = true;
        }
        if (collision.gameObject.CompareTag("Enemy/15"))
        {
            GameManager.gameManager.notspawn2 = true;
        }
        if (collision.gameObject.CompareTag("Enemy/20"))
        {
            GameManager.gameManager.notspawn2 = true;
        }

        if (collision.gameObject.CompareTag("Playerr/10"))
        {
            GameManager.gameManager.notspawn2 = true;
        }
        if (collision.gameObject.CompareTag("Playerr/15"))
        {
            GameManager.gameManager.notspawn2 = true;
        }
        if (collision.gameObject.CompareTag("Playerr/20"))
        {
            GameManager.gameManager.notspawn2 = true;
        }

    }
   
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy/10"))
        {
            GameManager.gameManager.notspawn2 = false;
        }
        if (collision.gameObject.CompareTag("Enemy/15"))
        {
            GameManager.gameManager.notspawn2 = false;
        }
        if (collision.gameObject.CompareTag("Enemy/20"))
        {
            GameManager.gameManager.notspawn2 = false;
        }

        if (collision.gameObject.CompareTag("Playerr/10"))
        {
            GameManager.gameManager.notspawn2 = false;
        }
        if (collision.gameObject.CompareTag("Playerr/15"))
        {
            GameManager.gameManager.notspawn2 = false;
        }
        if (collision.gameObject.CompareTag("Playerr/20"))
        {
            GameManager.gameManager.notspawn2 = false;
        }
    }
}
