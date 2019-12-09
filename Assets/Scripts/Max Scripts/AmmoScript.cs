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

    // Start is called before the first frame update
    void Start()
    {
        gun = transform.parent.gameObject;
        gunName = gun.name;
        ammoCount = ammoMax;
        ammoPool = poolCap;
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
            case "":
                ammoMax = 30;
                poolCap = 300;
                break;
            case "Disert Egal 50 CAL":
                ammoMax = 7;
                poolCap = 35;
                break;
            case "2":
                ammoMax = 30;
                poolCap = 300;
                break;
            case "3":
                ammoMax = 30;
                poolCap = 300;
                break;
            case "4":
                ammoMax = 30;
                poolCap = 300;
                break;
            case "5":
                ammoMax = 30;
                poolCap = 300;
                break;
            case "6":
                ammoMax = 30;
                poolCap = 300;
                break;
            case "7":
                ammoMax = 30;
                poolCap = 300;
                break;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "reloader" && ammoCount < ammoMax)
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

