using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;



public class SubHP : MonoBehaviour
{
    public int health = 5;
    public GameObject Player;
    public bool dead;
    public GameObject zombie;
    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Damage")
        {
            health--;
            if (health > 0)
            {
                Player.GetComponent<PlayerPoints>().points += 10;
            }
        }
        if (collision.gameObject.tag == "1911")
        {
            health--;
            if (health > 0)
            {
                Player.GetComponent<PlayerPoints>().points += 10;
            }
            
        }
        if (collision.gameObject.tag == "carbine")
        {
            health -= 3;
            if (health > 0)
            {
                Player.GetComponent<PlayerPoints>().points += 10;
            }
        }
        if (collision.gameObject.tag == "ak47")
        {
            health -= 2;
            if (health > 0)
            {
                Player.GetComponent<PlayerPoints>().points += 10;
            }
        }
        if (collision.gameObject.tag == "ak74")
        {
            health -= 1;
            if (health > 0)
            {
                Player.GetComponent<PlayerPoints>().points += 10;
            }
        }
        if (collision.gameObject.tag == "m4")
        {
            health -= 1;
            if (health > 0)
            {
                Player.GetComponent<PlayerPoints>().points += 10;
            }
        }
        if (collision.gameObject.tag == "deagle")
        {
            health -= 3;
            if (health > 0)
            {
                Player.GetComponent<PlayerPoints>().points += 10;
            }
        }
    }
    private void Update()
    {


        if (health <= 0)
        {
            if (!dead)
            {
                zombie.GetComponent<EnemyHp>().health = 0;
                dead = true;
            }
            

            


        }

    }
 
}
