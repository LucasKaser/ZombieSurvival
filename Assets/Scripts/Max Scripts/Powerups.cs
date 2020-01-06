using System.Collections;
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

        if(killTimerOn == true)
        {
            killTimer += Time.deltaTime;
            gameObject.GetComponent<referenceScript>().instaKill = true;
        }
        if(killTimer >= killTime)
        {
            gameObject.GetComponent<referenceScript>().instaKill = false;
            killTimerOn = false;
            killTimer = 0.0f;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "instaKill")
        {
            killTimerOn = true;
            Destroy(other.gameObject);
        }

        if(other.gameObject.tag == "maxAmmo")
        {
            magsArray = GameObject.FindGameObjectsWithTag("Mag");
            foreach (GameObject g in magsArray)
            {
                g.GetComponent<AmmoScript>().ammoCount = g.GetComponent<AmmoScript>().ammoMax;
                g.GetComponent<AmmoScript>().ammoPool = g.GetComponent<AmmoScript>().poolCap;
            }
            Destroy(other.gameObject);
        }

        if(other.gameObject.tag == "waveClear")
        {
            zombieArray = GameObject.FindGameObjectsWithTag("Zombie");
            foreach(GameObject z in zombieArray)
            {
                Destroy(z);
            }
            gameObject.GetComponent<PlayerPoints>().points += 500 * gameObject.GetComponent<PlayerPoints>().pointMult;
            Destroy(other.gameObject);
        }

        if(other.gameObject.tag == "dubPoints")
        {
            pointsTimerOn = true;
            Destroy(other.gameObject);
        }
    }
}
