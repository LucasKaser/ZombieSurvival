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
    public bool instaKill = false;

    //dmg int and multipliers
    public int dmgDmg = 1;
    public int dmg1911 = 1;
    public int dmgCarbine = 3;
    public int dmgAk47 = 2;
    public int dmgAk74 = 1;
    public int dmgM4 = 1;
    public int dmgDeagle = 3;

    public int dmgMult;

    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        dmgMult = Player.GetComponent<referenceScript>().dmgMult;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (instaKill == true)
        {
            if (collision.gameObject.tag == "Damage" || collision.gameObject.tag == "1911" || collision.gameObject.tag == "carbine"
                || collision.gameObject.tag == "ak47" || collision.gameObject.tag == "ak74" || collision.gameObject.tag == "m4" || collision.gameObject.tag == "deagle")
            {
                Debug.Log("BulletCollision");
                health = 0;
            }
        }
        if (instaKill == false)
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
    }
    private void Update()
    {
        dmgMult = Player.GetComponent<referenceScript>().dmgMult;

        dmgDmg = 1 * dmgMult;
        dmg1911 = 1 * dmgMult;
        dmgCarbine = 3 * dmgMult;
        dmgAk47 = 2 * dmgMult;
        dmgAk74 = 1 * dmgMult;
        dmgM4 = 1 * dmgMult;
        dmgDeagle = 3 * dmgMult;

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
