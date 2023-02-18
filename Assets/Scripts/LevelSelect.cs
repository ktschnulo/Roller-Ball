using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public void goBack()
    {
        SceneManager.LoadScene(0);
    }
    public void pickLevel1()
    {
        SceneManager.LoadScene(3);
    }
    public void pickLevel2()
    {
        SceneManager.LoadScene(4);
    }
    public void pickLevel3()
    {
        SceneManager.LoadScene(5);
    }
    public void pickLevel4()
    {
        SceneManager.LoadScene(6);
    }
    public void pickLevel5()
    {
        SceneManager.LoadScene(7);
    }
    public void pickLevel6()
    {
        SceneManager.LoadScene(8);
    }
}
