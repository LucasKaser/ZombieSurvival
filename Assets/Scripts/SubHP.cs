using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;



public class SubHP : MonoBehaviour
{
    public int health = 5;
    public Animator Enenmy;
    public GameObject Player;
    public int wait;
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
