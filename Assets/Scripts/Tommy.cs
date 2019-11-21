using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tommy : MonoBehaviour { 

    private SimpleShoot simpleShoot;
    private OVRGrabbable ovrgrabbable;
    public OVRInput.Button shootingbutton;

    // Start is called before the first frame update
    void Start()
    {
        simpleShoot = GetComponent<SimpleShoot>();
        ovrgrabbable = GetComponent<OVRGrabbable>();
    }

    // Update is called once per frame
    void Update()
    {
        if(ovrgrabbable.isGrabbed && OVRInput.GetDown(shootingbutton, ovrgrabbable.grabbedBy.GetController()))
        {
            simpleShoot.TriggerShoot();
        }
        
    }
}
