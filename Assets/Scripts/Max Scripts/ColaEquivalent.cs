using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColaEquivalent : MonoBehaviour
{
    public GameObject Player;
    public GameObject attachPoint;
    private OVRGrabbable ovrgrabbable;
    public int playerpoints;
    public int cost;
    public string colaName;
    public GameObject[] magsArray;

    //colas (grabbable objects like door unlocks)
    public bool dubDmg;
    public bool dubHealth;
    public bool fasterWalk;
    public bool ammoBoost;

    //magics (likely tags or names not gameObjects)
    //public GameObject maxAmmo;
    //public GameObject instaKill;
    //public GameObject waveClear;
    //public GameObject dubPoints;

    //pack-a-punch

    
    
    // Start is called before the first frame update
    void Start()
    {
        ovrgrabbable = GetComponent<OVRGrabbable>();
        Player = GameObject.FindGameObjectWithTag("Player");
        colaName = gameObject.name;
    }

    // Update is called once per frame
    void Update()
    {
        playerpoints = Player.GetComponent<PlayerPoints>().points;
        if (ovrgrabbable.isGrabbed && playerpoints >= cost)
        {
            Player.GetComponent<PlayerPoints>().points -= cost;
            switch (colaName)
            {
                case "dubDmg":
                    dubDmg = true;
                    attachPoint = GameObject.FindGameObjectWithTag("dubDmgAttach");
                    break;
                case "dubHealth":
                    dubHealth = true;
                    attachPoint = GameObject.FindGameObjectWithTag("dubHealthAttach");
                    break;
                case "fasterWalk":
                    fasterWalk = true;
                    attachPoint = GameObject.FindGameObjectWithTag("fasterWalkAttach");
                    break;
                case "ammoBoost":
                    ammoBoost = true;
                    attachPoint = GameObject.FindGameObjectWithTag("ammoBoostAttach");
                    break;
            }
            gameObject.SetActive(false);
        }
        
        if (!ovrgrabbable.isGrabbed)
        {
            transform.position = attachPoint.transform.position;
            transform.rotation = attachPoint.transform.rotation;
        }

        if(dubDmg == true)
        {
            Player.GetComponent<referenceScript>().dmgMult = 2;
        }
        if(dubHealth == true)
        {
            Player.GetComponent<PlayerHP>().colaMult = 2;
        }
        if(fasterWalk == true)
        {
            Player.GetComponent<OVRPlayerController>().MoveScaleMultiplier = 2f;
        }
        if(ammoBoost == true)
        {
            magsArray = GameObject.FindGameObjectsWithTag("Mag");
            foreach(GameObject g in magsArray)
            {
                //Debug.Log(g.name);
                
                g.GetComponent<AmmoScript>().dub = 2;
            }
        }

    }
}


//Double damage
    //the zombie has a set health, different parts of the body might add a multiplyer to the damage you do
    //the double damage perk would make it so you multiplied all damage after body part multipliers
//double health
    //pretty straight forward. doubles health
//speed/sprint speed increase
    //adds a small multiplier to the movement speed
//pool cap increase (larger total ammo pool)                            =======
    //gets every gun (probably a tag) and doubles their pool cap
//ammo max increase (larger clips)
    //gets every gun (probably a tag) and doubles their ammo max. 
    //this might not exist or might be a part of pool cap**             =======
//extra gun
    //trigger on back that if you release gun it snaps to back.
    //can grab it just by reaching and grabbing anywhere on the back area.
//



//pack-a-punch equivalent

//upgrades dmg and ammo caps.
//able to upgrade all guns (more than once with each price getting significantly higher)
//able to upgrade cola equivalents (more than once with each price getting significantly higher)
//item or location
    //item-found after large round completions and you just have to touch it to the gun/item you wish to upgrade
    //location-hard to reach spot (small ritual to get there or just dangerous) and you just have to drop the item into the slot to upgrade (weird for cola equivalent) (spits it out if you dont have enough points)
//