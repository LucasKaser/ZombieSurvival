using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ZombieGrab : MonoBehaviour
{
    public GameObject Player;
    public GameObject Zombie;
    public OVRGrabbable ovrgrabbable;
    public OVRInput.Button grabbutton;
    public BoxCollider collide;
    // Start is called before the first frame update
    void Start()
    {
        ovrgrabbable = GetComponent<OVRGrabbable>();
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (ovrgrabbable.isGrabbed)
        {
            Zombie.GetComponent<Animator>().enabled = false;
            collide.enabled = false;

        }
        else if(ovrgrabbable.isGrabbed && OVRInput.GetUp(grabbutton))
        {
            ovrgrabbable.grabbedBy.gameObject.GetComponent<OVRGrabber>().ForceRelease(gameObject.GetComponent<OVRGrabbable>());
            Zombie.GetComponent<Animator>().enabled = true;
            collide.enabled = true;

        }
    }
}
