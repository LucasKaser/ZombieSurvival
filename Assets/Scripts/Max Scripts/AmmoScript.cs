using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoScript : MonoBehaviour
{
    //ON MAG
    public bool magIn = false;
    public GameObject gun;
    public string gunName;
    public int ammoCount; //dynamic
    public int ammoMax; //static
    public int ammoPool; //dynamic
    public int poolCap; //static
    public bool firstClip = false;

    // Start is called before the first frame update
    void Start()
    {
        gun = transform.parent.gameObject;
        gunName = gun.name;
        //ammoCount = ammoMax;
        //ammoPool = poolCap;
    }
    // Update is called once per frame
    void Update()
    {
        switch (gunName)
        {
            case "g36":
                ammoMax = 30;
                poolCap = 300;
                break;
            case "UMP-45":
                ammoMax = 25;
                poolCap = 275;
                break;
            case "Disert Egal 50 CAL":
                ammoMax = 7;
                poolCap = 63;
                break;
            case "Skorpion VZ":
                ammoMax = 20;
                poolCap = 240;
                break;
            case "Enfield":
                ammoMax = 10;
                poolCap = 110;
                break;
            case "ak74m":
                ammoMax = 30;
                poolCap = 300;
                break;
            case "AK12":
                ammoMax = 30;
                poolCap = 300;
                break;
            case "thompson Variant":
                ammoMax = 20;
                poolCap = 120;
                break;
            case "PPSh-41":
                ammoMax = 71;
                poolCap = 284;
                break;
            case "S & W 500":
                ammoMax = 6;
                poolCap = 66;
                break;
        }

        if (!firstClip)
        {
            ammoCount = ammoMax;
            ammoPool = poolCap;
            firstClip = true;
        }

        if(ammoCount < 0)
        {
            ammoCount = 0;
        }
        if(ammoPool < 0)
        {
            ammoPool = 0;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "reloader" && ammoCount < ammoMax && gameObject.transform.parent.gameObject != gun)
        {
            if(ammoPool >= ammoMax)
            {
                ammoPool -= (ammoMax - ammoCount);
                ammoCount = ammoMax;
            }
            else if(ammoPool < ammoMax)
            {
                if(ammoPool + ammoCount <= ammoMax)
                {
                    ammoCount += ammoPool;
                    ammoPool = 0;
                }
                else
                {
                    ammoPool -= (ammoMax - ammoCount);
                    ammoCount = ammoMax;
                }
            }
        }
    }
}
//Ammo amounts (AM, PC)

//g36
    //AM = 30
    //PC = 300
//m4
    //AM = 30
    //PC = 300
//Deeg
    //AM = 7
    //PC = 35
//Revolver
    //AM = 6
    //PC = 36

