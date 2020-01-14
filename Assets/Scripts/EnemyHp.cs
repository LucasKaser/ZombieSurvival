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
    public bool dead;
    public int deathRoll = 0;
    public GameObject powerup1Pre;
    public GameObject powerup2Pre;
    public GameObject powerup3Pre;
    public GameObject powerup4Pre;
    public int dRMax = 4;
    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        //powerup1Pre = GameObject.FindGameObjectWithTag("dubPoints");
        //powerup2Pre = GameObject.FindGameObjectWithTag("waveClear");
        //powerup3Pre = GameObject.FindGameObjectWithTag("maxAmmo");
        //powerup4Pre = GameObject.FindGameObjectWithTag("instaKill");
    }

    /*void OnTriggerEnter(Collider collision)
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
    }*/

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
            Player.GetComponent<PlayerPoints>().points += 50 * Player.GetComponent<PlayerPoints>().pointMult;
            deathRoll = Random.Range(0, dRMax);
            Debug.Log(deathRoll);
            if (deathRoll == 0 && Player.GetComponent<referenceScript>().powerupCap > 0)
            {
                GameObject powerup1 = Instantiate(powerup1Pre, gameObject.transform.position, Quaternion.identity);
                Player.GetComponent<referenceScript>().powerupCap -= 1;
            }
            if(deathRoll == 1 && Player.GetComponent<referenceScript>().powerupCap > 0)
            {
                GameObject powerup2 = Instantiate(powerup2Pre, gameObject.transform.position, Quaternion.identity);
                Player.GetComponent<referenceScript>().powerupCap -= 1;
            }
            if (deathRoll == 2 && Player.GetComponent<referenceScript>().powerupCap > 0)
            {
                GameObject powerup3 = Instantiate(powerup3Pre, gameObject.transform.position, Quaternion.identity);
                Player.GetComponent<referenceScript>().powerupCap -= 1;
            }
            if (deathRoll == 3 && Player.GetComponent<referenceScript>().powerupCap > 0)
            {
                GameObject powerup4 = Instantiate(powerup4Pre, gameObject.transform.position, Quaternion.identity);
                Player.GetComponent<referenceScript>().powerupCap -= 1;
            }

            yield return new WaitForSeconds(wait);
            Destroy(gameObject);
        }
    }
}
