using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkLane1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Playerr/10"))
        {
            GameManager.gameManager.Lane1 = true;
            GameManager.gameManager.playerwt[0] += 10;
            GameManager.gameManager.playercount[0] += 1;
        }
        if (collision.gameObject.CompareTag("Playerr/15"))
        {
            GameManager.gameManager.Lane1 = true;
            GameManager.gameManager.playerwt[0] += 15;
            GameManager.gameManager.playercount[0] += 1;
        }
        if (collision.gameObject.CompareTag("Playerr/20"))
        {
            GameManager.gameManager.Lane1 = true;
            GameManager.gameManager.playerwt[0] += 20;
            GameManager.gameManager.playercount[0] += 1;
        }

        if (collision.gameObject.CompareTag("Enemy/10"))
        {
            GameManager.gameManager.enemywt[0] += 10;
            GameManager.gameManager.enemycount[0] += 1;
        }

        if (collision.gameObject.CompareTag("Enemy/15"))
        {
            GameManager.gameManager.enemywt[0] += 15;
            GameManager.gameManager.enemycount[0] += 1;
        }

        if (collision.gameObject.CompareTag("Enemy/20"))
        {
            GameManager.gameManager.enemywt[0] += 20;
            GameManager.gameManager.enemycount[0] += 1;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Playerr/10"))
        {
            GameManager.gameManager.Lane1 = false;
            GameManager.gameManager.playerwt[0] -= 10;
            GameManager.gameManager.playercount[0] -= 1;
        }
        if (collision.gameObject.CompareTag("Playerr/15"))
        {
            GameManager.gameManager.Lane1 = false;
            GameManager.gameManager.playerwt[0] -= 15; 
            GameManager.gameManager.playercount[0] -= 1;
        }
        if (collision.gameObject.CompareTag("Playerr/20"))
        {
            GameManager.gameManager.Lane1 = false;
            GameManager.gameManager.playerwt[0] -= 20;
            GameManager.gameManager.playercount[0] -= 1;
        }

        if (collision.gameObject.CompareTag("Enemy/10"))
        {
            
            GameManager.gameManager.enemywt[0] -= 10;
            GameManager.gameManager.enemycount[0] -= 1;

        }
        if (collision.gameObject.CompareTag("Enemy/15"))
        {

            GameManager.gameManager.enemywt[0] -= 15;
            GameManager.gameManager.enemycount[0] -= 1;

        }
        if (collision.gameObject.CompareTag("Enemy/20"))
        {

            GameManager.gameManager.enemywt[0] -= 20;
            GameManager.gameManager.enemycount[0] -= 1;

        }

    }

}
