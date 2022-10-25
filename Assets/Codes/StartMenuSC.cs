using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuSC : MonoBehaviour
{
   public void StartBt()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitBt()
    {
        Application.Quit();
    }
}
