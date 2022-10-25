using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Yenidenoyna : MonoBehaviour
{
    public void yenidenoyna()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Basket.kalanHak = 4;
        Time.timeScale = 1;
    }

    void Start()
    {
        Basket.kalanHak = 4;
        Basket.skor = 0;
    }

    public void ExitBt()
    {
        Application.Quit();

    }
}
