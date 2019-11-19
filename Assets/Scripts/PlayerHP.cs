using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHP : MonoBehaviour
{
    public float health = 15;
    public GameObject Enemy;
    public float wait;
    public float waiting;
    public int healthre;
    
    

  
    private void Start()
    {
        healthre = 3;
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Zombie" && wait>= 0.3)
        {
            wait = 0;
            health--;
            waiting = 0;
            if (health <= 0)
            {
                SceneManager.LoadScene("Preston Test Level");
            }

          



        }
    }

  
       



    private void Update()
    {
        wait += Time.deltaTime;
        waiting += Time.deltaTime;

        if (waiting > 5)
        {


            if (health <= 15)
            {
                health += .05f;
            }
            if (health > 15)
            {
                

                health = 15;
            }
        }

      
      






    }
    
   
}
