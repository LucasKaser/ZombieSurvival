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
        ovrgrabbable = GetComponent<OVRGrabbable>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3(0.00014f, 0.00014f, 0.00014f);
        if (!ovrgrabbable.isGrabbed)
        {
            transform.position = knifeAttach.transform.position;
            transform.rotation = knifeAttach.transform.rotation;
        }
        //transform.localScale = new Vector3 (0.00038f, 0.00038f, 0.00038f);
    }
}
