using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;



public class EnemyHp : MonoBehaviour
{
    public int health = 5;
    public Animator Enenmy;
    public GameObject Player;
    public int wait;
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
            if(GetComponent<Animator>() != null)
            {
                  GetComponent<Animator>().enabled = false;
                GetComponent<NavMove>().enabled = false;
                GetComponent<NavMeshAgent>().enabled = false;

            }
            StartCoroutine(death());

            

            Player.GetComponent<PlayerPoints>().points += 50;


        }

    }
    IEnumerator death()
    {
        while (true)
        {
            yield return new WaitForSeconds(wait);
            Destroy(gameObject);




        }
    }
}
