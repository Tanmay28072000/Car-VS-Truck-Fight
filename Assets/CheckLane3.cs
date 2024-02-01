using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckLane3 : MonoBehaviour
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
            GameManager.gameManager.Lane3 = true;
            GameManager.gameManager.playerwt[2] += 10;
            GameManager.gameManager.playercount[2] += 1;
        }
        if (collision.gameObject.CompareTag("Playerr/15"))
        {
            GameManager.gameManager.Lane3 = true;
            GameManager.gameManager.playerwt[2] += 15;
            GameManager.gameManager.playercount[2] += 1;
        }
        if (collision.gameObject.CompareTag("Playerr/20"))
        {
            GameManager.gameManager.Lane3 = true;
            GameManager.gameManager.playerwt[2] += 20;
            GameManager.gameManager.playercount[2] += 1;
        }
        if (collision.gameObject.CompareTag("Enemy/10"))
        {
            GameManager.gameManager.enemywt[2] += 10;
            GameManager.gameManager.enemycount[2] += 1;

        }

        if (collision.gameObject.CompareTag("Enemy/15"))
        {
            GameManager.gameManager.enemywt[2] += 15;
            GameManager.gameManager.enemycount[2] += 1;

        }

        if (collision.gameObject.CompareTag("Enemy/20"))
        {
            GameManager.gameManager.enemywt[2] += 20;
            GameManager.gameManager.enemycount[2] += 1;

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Playerr/10"))
        {
            GameManager.gameManager.Lane3 = false;
            GameManager.gameManager.playerwt[2] -= 10;
            GameManager.gameManager.playercount[2] -= 1;
        }
        if (collision.gameObject.CompareTag("Playerr/15"))
        {
            GameManager.gameManager.Lane3 = false;
            GameManager.gameManager.playerwt[2] -= 15;
            GameManager.gameManager.playercount[2] -= 1;
        }
        if (collision.gameObject.CompareTag("Playerr/20"))
        {
            GameManager.gameManager.Lane3 = false;
            GameManager.gameManager.playerwt[2] -= 20;
            GameManager.gameManager.playercount[2] -= 1;
        }
        if (collision.gameObject.CompareTag("Enemy/10"))
        {

            GameManager.gameManager.enemywt[2] -= 10;
            GameManager.gameManager.enemycount[2] -= 1;

        }
        if (collision.gameObject.CompareTag("Enemy/15"))
        {

            GameManager.gameManager.enemywt[2] -= 15;
            GameManager.gameManager.enemycount[2] -= 1;

        }
        if (collision.gameObject.CompareTag("Enemy/20"))
        {

            GameManager.gameManager.enemywt[2] -= 20;
            GameManager.gameManager.enemycount[2] -= 1;

        }
    }
}
