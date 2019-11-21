using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tommy : MonoBehaviour { 

    private FullAuto simpleShoot;
    private OVRGrabbable ovrgrabbable;
    public OVRInput.Button shootingbutton;

    // Start is called before the first frame update
    void Start()
    {
        simpleShoot = GetComponent<FullAuto>();
        ovrgrabbable = GetComponent<OVRGrabbable>();
    }

    // Update is called once per frame
    void Update()
    {
        if(ovrgrabbable.isGrabbed && OVRInput.GetDown(shootingbutton, ovrgrabbable.grabbedBy.GetController()))
        {
            simpleShoot.shoot = true;
        }
        if (ovrgrabbable.isGrabbed && OVRInput.GetUp(shootingbutton, ovrgrabbable.grabbedBy.GetController()))
        {
            simpleShoot.shoot = false;
        }
    }
}
