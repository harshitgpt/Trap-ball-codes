using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField] AudioSource boo;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
           
            boo.Play();
            Invoke("ResumePanel", 2.0f);
            Score.score = 1;

        }
    }

    public void  ResumePanel()
    {
        SceneManager.LoadScene(2);

    }


}


