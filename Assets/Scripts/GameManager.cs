using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
   public int store;
    [SerializeField] public Transform[] PlayerSpawnpos;
    [SerializeField] public GameObject[] player;
     public bool notspawn1;
    public bool notspawn2;

    [SerializeField] public int PlayerHealth = 100;
    [SerializeField] public int AIHealth = 100;

    [SerializeField] public Transform[] enemySpawnpos;
    [SerializeField] public GameObject[] enemy;

    public float spawnTime = 0f;
    public float playerSpawnTime;
    float enemyTime = 0f;
    [SerializeField] float enemySpawnTime;

    private GameObject sheepClone;
    private GameObject enemyClone;

    bool enemspawn;
    bool L1;
    bool L2;
    bool L3;
    bool L4;
    bool L5;

    public bool st; 

    public int plSerial;

    public int[] playerwt;
    public int[] enemywt;

    public int[] playercount;
    public int[] enemycount;

    public bool Lane1;
    public bool Lane2;
    public bool Lane3;
    public bool Lane4;
    public bool Lane5;

    public static GameManager gameManager;

    // Start is called before the first frame update
    private void Awake()
    {
        if (gameManager == null)
        {
            gameManager = this;
        }
        else
        {
            Destroy(this);
        }
       // DontDestroyOnLoad(this.gameObject);
    }


    // Update is called once per frame
    void Update()
    {
        //Debug.Log("pl" + playerwt[0] + "  " + "em" + enemywt[0]);
        if (spawnTime >= -5)
            spawnTime -= Time.deltaTime;

        if (enemyTime >= 0)
            enemyTime -= Time.deltaTime;

        if (enemspawn && st)
        {
            if(enemyTime <= 0)
            EnemySpawn();
        }

        if (Input.GetMouseButtonDown(0) && spawnTime <= 0 && st)
        {

        SheepSpawn();
        }
        
    }
    void SheepSpawn()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit2D clickPosition = Physics2D.GetRayIntersection(ray);
        if (clickPosition.collider != null)
        {


            enemspawn = true;
            if (clickPosition.transform.CompareTag("Lane1"))
            {
                if (notspawn1 && (playercount[0] + enemycount[0] >= 4))
                {
                    Debug.Log("Choose Another Lane");
                }
                else
                {
                    InstantiateSheeps(PlayerSpawnpos[0]);
                    spawnTime = playerSpawnTime;
                    L1 = true;
                    L2 = false;
                    L3 = false;
                    L4 = false;
                    L5 = false;
                }
               
            }

            if (clickPosition.transform.CompareTag("Lane2"))
            {
                if (notspawn1 && (playercount[1] + enemycount[1] >= 4))
                {
                    Debug.Log("Choose Another Lane");
                }
                else
                {
                    InstantiateSheeps(PlayerSpawnpos[1]);
                    spawnTime = playerSpawnTime;
                    L1 = false;
                    L2 = true;
                    L3 = false;
                    L4 = false;
                    L5 = false;
                }
            }

            if (clickPosition.transform.CompareTag("Lane3"))
            {
                if (notspawn1 && (playercount[2] + enemycount[2] >= 4))
                {
                    Debug.Log("Choose Another Lane");
                }
                else
                {
                    InstantiateSheeps(PlayerSpawnpos[2]);
                    spawnTime = playerSpawnTime;
                    L1 = false;
                    L2 = false;
                    L3 = true;
                    L4 = false;
                    L5 = false;
                }
            }

            if (clickPosition.transform.CompareTag("Lane4"))
            {
                if (notspawn1 && (playercount[3] + enemycount[3] >= 4))
                {
                    Debug.Log("Choose Another Lane");
                }
                else
                {
                    InstantiateSheeps(PlayerSpawnpos[3]);
                    spawnTime = playerSpawnTime;
                    L1 = false;
                    L2 = false;
                    L3 = false;
                    L4 = true;
                    L5 = false;
                }
            }

            if (clickPosition.transform.CompareTag("Lane5"))
            {
                if (notspawn1 && (playercount[4] + enemycount[4] >= 4))
                {
                    Debug.Log("Choose Another Lane");
                }
                else
                {
                    InstantiateSheeps(PlayerSpawnpos[4]);
                    spawnTime = playerSpawnTime;
                    L1 = false;
                    L2 = false;
                    L3 = false;
                    L4 = false;
                    L5 = true;
                }
            }

            if (clickPosition.transform.CompareTag("Untagged")) 
                Debug.Log("No SpawnPoint");
        }
        else Debug.Log("Nope");

    }
    public void EnemySpawn()
    {
        if (playerwt[0] <= enemywt[0] && (enemywt[0] - playerwt[0] == 0 || enemywt[0] - playerwt[0] <= 10) && Lane1)
        {
            InstantiateEnemy(enemySpawnpos[0]);
            enemyTime = enemySpawnTime;
        }
        else if (playerwt[1] <= enemywt[1] && (enemywt[0] - playerwt[1] == 0 || enemywt[1] - playerwt[1] <= 10) && Lane2)
        {
            InstantiateEnemy(enemySpawnpos[1]);
            enemyTime = enemySpawnTime;
        }
        else if (playerwt[2] <= enemywt[2] && (enemywt[2] - playerwt[2] == 0 || enemywt[2] - playerwt[2] <= 10) && Lane3)
        {
            InstantiateEnemy(enemySpawnpos[2]);
            enemyTime = enemySpawnTime;
        }
        else if (playerwt[3] <= enemywt[3] && (enemywt[3] - playerwt[3] == 0 || enemywt[3] - playerwt[3] <= 10) && Lane4)
        {
            InstantiateEnemy(enemySpawnpos[3]);
            enemyTime = enemySpawnTime;
        }
        else if (playerwt[4] <= enemywt[4] && (enemywt[4] - playerwt[4] == 0 || enemywt[4] - playerwt[4] <= 10) && Lane5)
        {
            InstantiateEnemy(enemySpawnpos[4]);
            enemyTime = enemySpawnTime;
        }
        else
        {

            if (L1)
            {
                if (spawnTime <= -2 && !Lane1)
                {
                    InstantiateEnemy(enemySpawnpos[Random.Range(1, 4)]);
                    enemyTime = enemySpawnTime;
                }
                else
                {

                    if (notspawn2)
                    {
                        InstantiateEnemy(enemySpawnpos[Random.Range(1, 4)]);
                        enemyTime = enemySpawnTime;
                    }
                    else
                    {
                        InstantiateEnemy(enemySpawnpos[0]);
                        enemyTime = enemySpawnTime;
                    }
                }
            }

            if (L2)
            {
                if (spawnTime <= -2 && !Lane2)
                {
                    InstantiateEnemy(enemySpawnpos[Random.Range(2, 4)]);
                    enemyTime = enemySpawnTime;
                }
                else
                {


                    if (notspawn2)
                    {
                        InstantiateEnemy(enemySpawnpos[Random.Range(2, 4)]);
                        enemyTime = enemySpawnTime;
                    }
                    else
                    {
                        InstantiateEnemy(enemySpawnpos[1]);
                        enemyTime = enemySpawnTime;
                    }
                }

            }
            if (L3)
            {
                if (spawnTime <= -2 && !Lane3)
                {
                    InstantiateEnemy(enemySpawnpos[Random.Range(3, 4)]);
                    enemyTime = enemySpawnTime;
                }
                else
                {


                    if (notspawn2)
                    {
                        InstantiateEnemy(enemySpawnpos[Random.Range(3, 4)]);
                        enemyTime = enemySpawnTime;
                    }
                    else
                    {
                        InstantiateEnemy(enemySpawnpos[2]);
                        enemyTime = enemySpawnTime;
                    }
                }
            }
            if (L4)
            {
                if (spawnTime <= -2 && !Lane4)
                {
                    InstantiateEnemy(enemySpawnpos[Random.Range(0, 2)]);
                    enemyTime = enemySpawnTime;
                }
                else
                {


                    if (notspawn2)
                    {
                        InstantiateEnemy(enemySpawnpos[Random.Range(0, 2)]);
                        enemyTime = enemySpawnTime;
                    }
                    else
                    {
                        InstantiateEnemy(enemySpawnpos[3]);
                        enemyTime = enemySpawnTime;
                    }
                }
            }
            if (L5)
            {
                if (spawnTime <= -2 && !Lane5)
                {
                    InstantiateEnemy(enemySpawnpos[Random.Range(0, 3)]);
                    enemyTime = enemySpawnTime;
                }
                else
                {


                    if (notspawn2)
                    {
                        InstantiateEnemy(enemySpawnpos[Random.Range(0, 3)]);
                        enemyTime = enemySpawnTime;
                    }
                    else
                    {
                        InstantiateEnemy(enemySpawnpos[4]);
                        enemyTime = enemySpawnTime;
                    }
                }
            }
        }
    }
    void InstantiateSheeps(Transform chooseLane)
    {
      
        //sheepClone = Instantiate(player[Random.Range(0, player.Length)], chooseLane.position, Quaternion.identity);
       if(store == 1)
        {
            sheepClone = Instantiate(player[0], chooseLane.position, Quaternion.identity);
        }
        if (store == 2)
        {
            sheepClone = Instantiate(player[1], chooseLane.position, Quaternion.identity);
        }
        if (store == 3)
        {
            sheepClone = Instantiate(player[2], chooseLane.position, Quaternion.identity);
        }
    }
    void InstantiateEnemy(Transform choosepos)
    {
        enemyClone = Instantiate(enemy[Random.Range(0, enemy.Length)], choosepos.position, Quaternion.identity);
    }


}
