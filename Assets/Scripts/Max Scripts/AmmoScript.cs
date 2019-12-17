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
    public int dub = 1;

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
                ammoMax = 30 * dub;
                poolCap = 300 * dub;
                break;
            case "UMP-45":
                ammoMax = 25 * dub;
                poolCap = 275 * dub;
                break;
            case "Disert Egal 50 CAL":
                ammoMax = 7 * dub;
                poolCap = 63 * dub;
                break;
            case "Skorpion VZ":
                ammoMax = 20 * dub;
                poolCap = 240 * dub;
                break;
            case "Enfield":
                ammoMax = 10 * dub;
                poolCap = 110 * dub;
                break;
            case "ak74m":
                ammoMax = 30 * dub;
                poolCap = 300 * dub;
                break;
            case "AK12":
                ammoMax = 30 * dub;
                poolCap = 300 * dub;
                break;
            case "thompson Variant":
                ammoMax = 20 * dub;
                poolCap = 120 * dub;
                break;
            case "PPSh-41":
                ammoMax = 71 * dub;
                poolCap = 284 * dub;
                break;
            case "S & W 500":
                ammoMax = 6 * dub;
                poolCap = 66 * dub;
                break;
                 case "1911":
                ammoMax = 7 * dub;
                poolCap = 42 * dub;
                break;
            case "Ak-47 (1)":
                ammoMax = 30 * dub;
                poolCap = 330 * dub;
                break;
            case "M4A1_PBR":
                ammoMax = 30 * dub;
                poolCap = 330 * dub;
                break;
            case "SubmachineGun":
                ammoMax = 32 * dub;
                poolCap = 342 * dub;
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

