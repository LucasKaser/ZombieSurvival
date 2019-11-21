﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;



public class EnemyHp : MonoBehaviour
{
    public int health = 5;
    public Animator Enenmy;
    public GameObject Player;
    public int wait;
    public bool dead;
    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }
    void OnTriggerEnter(Collider collision)
    {
        Debug.Log(collision.gameObject.name);
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
            if(GetComponent<Animator>() != null)
            {
                  GetComponent<Animator>().enabled = false;
                GetComponent<NavMove>().enabled = false;
                GetComponent<NavMeshAgent>().enabled = false;

            }
            if (!dead)
            {
                StartCoroutine(death());
            }
            

            


        }

    }
    IEnumerator death()
    {
        while (true)
        {
            dead = true;
            Player.GetComponent<PlayerPoints>().points += 50;
            yield return new WaitForSeconds(wait);

            Destroy(gameObject);




        }
    }
}
