using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{

   public void Replaygame()
    {
        
        SceneManager.LoadScene(1);
        

    }

    public void Leftgame()
    {
        Application.Quit();

    }
}
