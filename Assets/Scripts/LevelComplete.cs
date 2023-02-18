using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public Text finalCoinText;
    public Text finalTimerText;

    void Start()
    {
        string time = PlayerController.finalTime;
        string coin = PlayerController.finalCoins;
        finalTimerText.text = time;
        finalCoinText.text = coin;
    }

    public void nextLevel()
    {
        int nextInd = PlayerController.ind + 1;
        if (nextInd < 5)
        {
            SceneManager.LoadScene(nextInd);
        }
        else
        {
            SceneManager.LoadScene(0);
        }
    }
}
