using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class referenceScript : MonoBehaviour
{
    public int dmgMult = 1;
    public bool instaKill = false;
    public int powerupCap = 4;
    
    
    // Start is called before the first frame update
    void Start()
    {
        dmgMult = 1;
    }
}


//known bugs or issues
//the insta kill doesn't delete after passing through it
//the knife does no damage

//things to do
//gun placement
//cola placement
//map design
//spawning
//assets
