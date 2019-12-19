﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerups : MonoBehaviour
{
    public GameObject[] magsArray;
    public GameObject[] zombieArray;
    public bool pointsTimerOn = false;
    public bool killTimerOn = false;
    public float pointsTimer = 0.0f;
    public float pointsTime = 10.0f;
    public float killTimer = 0.0f;
    public float killTime = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(pointsTimerOn == true)
        {
            pointsTimer += Time.deltaTime;
            gameObject.GetComponent<PlayerPoints>().pointMult = 2;
        }
        if(pointsTimer >= pointsTime)
        {
            gameObject.GetComponent<PlayerPoints>().pointMult = 1;
            pointsTimerOn = false;
            pointsTimer = 0.0f;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "instaKill")
        {
            //REMEMBER TIMER
            
            //make all damage insanely high
            //or set all zombie health to 1
        }

        if(other.gameObject.tag == "maxAmmo")
        {
            magsArray = GameObject.FindGameObjectsWithTag("Mag");
            foreach (GameObject g in magsArray)
            {
                g.GetComponent<AmmoScript>().ammoCount = g.GetComponent<AmmoScript>().ammoMax;
                g.GetComponent<AmmoScript>().ammoPool = g.GetComponent<AmmoScript>().poolCap;
            }
        }

        if(other.gameObject.tag == "waveClear")
        {
            zombieArray = GameObject.FindGameObjectsWithTag("Zombie");
            foreach(GameObject z in zombieArray)
            {
                Destroy(z);
            }
            gameObject.GetComponent<PlayerPoints>().points += 500 * gameObject.GetComponent<PlayerPoints>().pointMult;
        }

        if(other.gameObject.tag == "dubPoints")
        {
            pointsTimerOn = true;
        }
    }
}
