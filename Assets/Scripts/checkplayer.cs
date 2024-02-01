using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkplayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //GameManager.gameManager.notspawn1 = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy/10"))
        {
            GameManager.gameManager.notspawn1 = true;
        }
        if (collision.gameObject.CompareTag("Enemy/15"))
        {
            GameManager.gameManager.notspawn1 = true;
        }
        if (collision.gameObject.CompareTag("Enemy/20"))
        {
            GameManager.gameManager.notspawn1 = true;
        } 

        if (collision.gameObject.CompareTag("Playerr/10"))
        {
            GameManager.gameManager.notspawn1 = true;
        }
        if (collision.gameObject.CompareTag("Playerr/15"))
        {
            GameManager.gameManager.notspawn1 = true;
        }
        if (collision.gameObject.CompareTag("Playerr/20"))
        {
            GameManager.gameManager.notspawn1 = true;
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy/10"))
        {
            GameManager.gameManager.notspawn1 = false;
        }
        if (collision.gameObject.CompareTag("Enemy/15"))
        {
            GameManager.gameManager.notspawn1 = false;
        }
        if (collision.gameObject.CompareTag("Enemy/20"))
        {
            GameManager.gameManager.notspawn1 = false;
        }

        if (collision.gameObject.CompareTag("Playerr/10"))
        {
            GameManager.gameManager.notspawn1 = false;
        }
        if (collision.gameObject.CompareTag("Playerr/15"))
        {
            GameManager.gameManager.notspawn1 = false;
        }
        if (collision.gameObject.CompareTag("Playerr/20"))
        {
            GameManager.gameManager.notspawn1 = false;
        }
    }
}
