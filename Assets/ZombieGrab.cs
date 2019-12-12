using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ZombieGrab : MonoBehaviour
{
    public GameObject Player;
    public Animator animator;
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
        if (ovrgrabbable.isGrabbed && OVRInput.GetDown(grabbutton, ovrgrabbable.grabbedBy.GetController()))
        {
            Debug.Log("kinda cringe bruh");
            animator.enabled = false;
            collide.enabled = false;

        }
        else if(ovrgrabbable.isGrabbed && OVRInput.GetUp(grabbutton, ovrgrabbable.grabbedBy.GetController()))
        {
            ovrgrabbable.grabbedBy.gameObject.GetComponent<OVRGrabber>().ForceRelease(gameObject.GetComponent<OVRGrabbable>());
            Zombie.GetComponent<Animator>().enabled = true;
            collide.enabled = true;

        }
    }
}
