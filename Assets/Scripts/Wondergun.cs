using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wondergun : MonoBehaviour
{
    public GameObject zapper;
    private OVRGrabbable ovrgrabbable;
    public OVRInput.Button shootingbutton;
    // Start is called before the first frame update
    void Start()
    {
        ovrgrabbable = GetComponent<OVRGrabbable>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ovrgrabbable.isGrabbed && OVRInput.GetDown(shootingbutton, ovrgrabbable.grabbedBy.GetController()))
        {
            zapper.SetActive(true);
        }
        else if (ovrgrabbable.isGrabbed && OVRInput.GetUp(shootingbutton, ovrgrabbable.grabbedBy.GetController()))
        {
            zapper.SetActive(false);
        }
    }
}
