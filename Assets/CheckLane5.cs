using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckLane5 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Playerr/10"))
        {
            GameManager.gameManager.Lane5 = true;
            GameManager.gameManager.playerwt[4] += 10;
            GameManager.gameManager.playercount[4] += 1;

        }
        if (collision.gameObject.CompareTag("Playerr/15"))
        {
            GameManager.gameManager.Lane5 = true;
            GameManager.gameManager.playerwt[4] += 15;
            GameManager.gameManager.playercount[4] += 1;
        }
        if (collision.gameObject.CompareTag("Playerr/20"))
        {
            GameManager.gameManager.Lane5 = true;
            GameManager.gameManager.playerwt[4] += 20;
            GameManager.gameManager.playercount[4] += 1;
        }
        if (collision.gameObject.CompareTag("Enemy/10"))
        {
            GameManager.gameManager.enemywt[4] += 10;
            GameManager.gameManager.enemycount[4] += 1;

        }

        if (collision.gameObject.CompareTag("Enemy/15"))
        {
            GameManager.gameManager.enemywt[4] += 15;
            GameManager.gameManager.enemycount[4] += 1;

        }

        if (collision.gameObject.CompareTag("Enemy/20"))
        {
            GameManager.gameManager.enemywt[4] += 20;
            GameManager.gameManager.enemycount[4] += 1;

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Playerr/10"))
        {
            GameManager.gameManager.Lane5 = false;
            GameManager.gameManager.playerwt[4] -= 10;
            GameManager.gameManager.playercount[4] -= 1;

        }
        if (collision.gameObject.CompareTag("Playerr/15"))
        {
            GameManager.gameManager.Lane5 = false;
            GameManager.gameManager.playerwt[4] -= 15;
            GameManager.gameManager.playercount[4] -= 1;

        }
        if (collision.gameObject.CompareTag("Playerr/20"))
        {
            GameManager.gameManager.Lane5 = false;
            GameManager.gameManager.playerwt[4] -= 20;
            GameManager.gameManager.playercount[4] -= 1;

        }
        if (collision.gameObject.CompareTag("Enemy/10"))
        {

            GameManager.gameManager.enemywt[4] -= 10;
            GameManager.gameManager.enemycount[4] -= 1;

        }
        if (collision.gameObject.CompareTag("Enemy/15"))
        {

            GameManager.gameManager.enemywt[4] -= 15;
            GameManager.gameManager.enemycount[4] -= 1;

        }
        if (collision.gameObject.CompareTag("Enemy/20"))
        {

            GameManager.gameManager.enemywt[4] -= 20;
            GameManager.gameManager.enemycount[4] -= 1;

        }
    }
}
