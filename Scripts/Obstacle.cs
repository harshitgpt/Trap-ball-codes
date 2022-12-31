using System.Collections;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] GameObject obstacle;
    

    void Start()
    {
        obstacle.SetActive(false);

    }

   
    void Update()
    {
        if(Input.touchCount > 0 || Input.GetMouseButtonDown(0))
        {
            StartCoroutine(Tapobstacle());
        }
    }

   IEnumerator Tapobstacle()
    {

        obstacle.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        obstacle.SetActive(false);


    }

    


}
