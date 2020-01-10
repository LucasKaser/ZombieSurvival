using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeScript : MonoBehaviour
{
    public GameObject knifeAttach;
    private OVRGrabbable ovrgrabbable;


    // Start is called before the first frame update
    void Start()
    {
        knifeAttach = GameObject.FindGameObjectWithTag("knifeAttach");
    }

    // Update is called once per frame
    void Update()
    {  
        if (!ovrgrabbable.isGrabbed)
        {
            transform.position = knifeAttach.transform.position;
            transform.rotation = knifeAttach.transform.rotation;
        }
    }
}
