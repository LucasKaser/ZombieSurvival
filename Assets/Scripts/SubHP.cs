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
    public int dmg1911 = 2;
    public int dmgCarbine = 3;
    public int dmgAk47 = 2;
    public int dmgAk74 = 2;
    public int dmgM4 = 1;
    public int dmgDeagle = 4;
    public int dmgEnfield = 8;
    public int ifInsta = 1;
    public int dmgKnife = 1;

    public int dmgMult;

    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        dmgMult = Player.GetComponent<referenceScript>().dmgMult * ifInsta;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "knife")
        {
            health -= dmgKnife;
            if (health > 0)
            {
                Player.GetComponent<PlayerPoints>().points += 10 * Player.GetComponent<PlayerPoints>().pointMult;
            }
        }
        if (collision.gameObject.tag == "Damage")
        {
            health -= dmgDmg;
            if (health > 0)
            {
                Player.GetComponent<PlayerPoints>().points += 10 * Player.GetComponent<PlayerPoints>().pointMult;
            }
        }
        if (collision.gameObject.tag == "1911")
        {
            health -= dmg1911;
            if (health > 0)
            {
                Player.GetComponent<PlayerPoints>().points += 10 * Player.GetComponent<PlayerPoints>().pointMult;
            }

        }
        if (collision.gameObject.tag == "carbine")
        {
            health -= dmgCarbine;
            if (health > 0)
            {
                Player.GetComponent<PlayerPoints>().points += 10 * Player.GetComponent<PlayerPoints>().pointMult;
            }
        }
        if (collision.gameObject.tag == "ak47")
        {
            health -= dmgAk47;
            if (health > 0)
            {
                Player.GetComponent<PlayerPoints>().points += 10 * Player.GetComponent<PlayerPoints>().pointMult;
            }
        }
        if (collision.gameObject.tag == "ak74")
        {
            health -= dmgAk74;
            if (health > 0)
            {
                Player.GetComponent<PlayerPoints>().points += 10 * Player.GetComponent<PlayerPoints>().pointMult;
            }
        }
        if (collision.gameObject.tag == "m4")
        {
            health -= dmgM4;
            if (health > 0)
            {
                Player.GetComponent<PlayerPoints>().points += 10 * Player.GetComponent<PlayerPoints>().pointMult;
            }
        }
        if (collision.gameObject.tag == "deagle")
        {
            health -= dmgDeagle;
            if (health > 0)
            {
                Player.GetComponent<PlayerPoints>().points += 10 * Player.GetComponent<PlayerPoints>().pointMult;
            }
        }
        if (collision.gameObject.tag == "enfield")
        {
            health -= dmgEnfield;
            if (health > 0)
            {
                Player.GetComponent<PlayerPoints>().points += 10 * Player.GetComponent<PlayerPoints>().pointMult;
            }
        }

    }
    private void Update()
    {
        Player = GameObject.FindGameObjectWithTag("Player");

        dmgMult = Player.GetComponent<referenceScript>().dmgMult * ifInsta;

        dmgDmg = 1 * dmgMult;
        dmg1911 = 2 * dmgMult;
        dmgCarbine = 3 * dmgMult;
        dmgAk47 = 2 * dmgMult;
        dmgAk74 = 2 * dmgMult;
        dmgM4 = 1 * dmgMult;
        dmgDeagle = 4 * dmgMult;
        dmgEnfield = 8 * dmgMult;
        dmgKnife = 1 * dmgMult;
        if (Player.GetComponent<referenceScript>().instaKill == true)
        {
            ifInsta = 9999;
        }
        if(Player.GetComponent<referenceScript>().instaKill == false)
        {
            ifInsta = 1;
        }
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
