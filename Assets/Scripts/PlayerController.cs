using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    //variables
    public static int ind;
    public static string finalTime;
    public static string finalCoins;
    public Text coinText;
    public Text timerText;
    public float currentTime;
    bool timerStarted = false;
    private int coinCount;

    // Start is called before the first frame update
    void Start()
    {
        ind = SceneManager.GetActiveScene().buildIndex;
        finalTime = "";
        finalCoins = "";
        coinCount = 0;
        coinText.text = "Coins: " + coinCount;
        currentTime = 0;
    }

    void DisplayTime(float timeToDisplay)
    {
        if (timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }
        string minutes = ((int)currentTime / 60).ToString();
        string seconds = (currentTime % 60).ToString("f2");

        if (currentTime % 60 < 10)
        {
            timerText.text = "Timer: " + minutes + ":0" + seconds;
        }
        else
        {
            timerText.text = "Timer: " + minutes + ":" + seconds;
        }
    }

    void Update()
    {
        
        if (timerStarted == true)
        {
            currentTime += Time.deltaTime;
            DisplayTime(currentTime);
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D) ||
                Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.DownArrow))
            {
                timerStarted = true;
            }
        }
        if (Input.GetKeyDown(KeyCode.Escape)){
            SceneManager.LoadScene(0);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            coinCount = coinCount + 1;
            coinText.text = "Coins: " + coinCount;
            other.gameObject.SetActive(false);
        }
        else if (other.gameObject.CompareTag("Key"))
        {
            other.gameObject.SetActive(false);
        }
        else if (other.gameObject.CompareTag("Spikes1"))
        {
            this.gameObject.transform.position = new Vector3(0, 32, 138);
        }
        else if (other.gameObject.CompareTag("Spikes2"))
        {
            this.gameObject.transform.position = new Vector3(0, 2, 63);
        }
        else if (other.gameObject.CompareTag("Saw1"))
        {
            this.gameObject.transform.position = new Vector3(0, 32, 138);
        }
        else if (other.gameObject.CompareTag("Button"))
        {
            finalTime = timerText.text;
            finalCoins = coinText.text;
            SceneManager.LoadScene(2);
        }
    }
}
