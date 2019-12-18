﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PlayerHP : MonoBehaviour
{
    public float health;
    public float maxHealth = 15;
    public float healthRegen = 0.05f;
    public GameObject Enemy;
    public float wait;
    public float waiting;
    public int healthre;
    public Text Health;
    public float colaMult = 1;
   
     
    

  
    private void Start()
    {
        healthre = 3;
        health = maxHealth;
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


            if (health <= maxHealth * colaMult)
            {
                health += healthRegen * colaMult;
            }
            if (health > maxHealth * colaMult)
            {
                

                health = maxHealth * colaMult;
            }
        }
        

      
      
        





    }
    
   
}
