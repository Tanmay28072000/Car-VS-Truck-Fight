using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class UiController : MonoBehaviour
{
    [SerializeField] public Slider[] Health;
    [SerializeField] public Image img;
    [SerializeField] public Image[] plimg;
    [SerializeField] GameObject[] panel;

    public TMP_Text PlHealth;
    public TMP_Text EnemHealth;
    public List<Sprite> serial;
    public Button startbutton;

    public int[] carList;
    public Queue<int> pickCar = new Queue<int>();
    int g,f;
    int x;


    // Start is called before the first frame update
    void Start()
    {
        DisplayImage();
        f = carList[Random.Range(0, carList.Length)];
        //f = Random.Range(carList[0], carList.Length);
        pickCar.Enqueue(f);
        plimg[0].sprite = serial[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && GameManager.gameManager.spawnTime <= 0 && GameManager.gameManager.st)
        {
            g = carList[Random.Range(0, carList.Length)];
            pickCar.Enqueue(g);
            GameManager.gameManager.store = pickCar.Dequeue();
            Debug.Log(g);
            DisplayImage();
        }
        Health[0].value = GameManager.gameManager.PlayerHealth;
        Health[1].value = GameManager.gameManager.AIHealth;
        img.fillAmount = GameManager.gameManager.spawnTime / GameManager.gameManager.playerSpawnTime;

        PlHealth.text = Health[0].value.ToString();
        EnemHealth.text = Health[1].value.ToString();
        if(Health[0].value <= 0)
        {
            Loserpanel();
        }
        if(Health[1].value <= 0)
        {
            winnerpanel();
        }
    }
    public void DisplayImage()
    {

        if (g == 1)
        {
            plimg[0].sprite = serial[0];
        }
        else if (g == 2)
        {
            plimg[0].sprite = serial[1];
        }
        else if (g == 3)
        {
            plimg[0].sprite = serial[2];
        }



    }
    public void startbtnfunc()
    {
        GameManager.gameManager.st = true;
        panel[0].SetActive(false);
        g = carList[Random.Range(0, carList.Length)];
        pickCar.Enqueue(g);
        GameManager.gameManager.store = pickCar.Dequeue();
        Debug.Log(g);
        DisplayImage();
    }

    public void winnerpanel()
    {
        GameManager.gameManager.st = false;
        panel[1].SetActive(true);
    }
    public void Loserpanel()
    {
        GameManager.gameManager.st = false;
        panel[2].SetActive(true);
    }

    public void restartbtnfunc()
    {
        SceneManager.LoadScene("SampleScene");
    }
}

