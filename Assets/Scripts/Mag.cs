using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mag : MonoBehaviour
{
    public int roundsLeft;


    public MagSlot slot;
    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<MagSlot>() != null)
        {
            other.GetComponent<MagSlot>().AttachMag(this);
            GetComponent<BoxCollider>().enabled = false;

            GetComponent<OVRGrabbable>().grabbedBy.gameObject.GetComponent<OVRGrabber>().ForceRelease(gameObject.GetComponent<OVRGrabbable>());

            Transform attachPoint = slot.transform.Find("AttachPoint");
            transform.position = attachPoint.position;
            transform.rotation = attachPoint.rotation;
            transform.parent = attachPoint;

        }
    }
    public void PickUp()
    {
        if (slot != null)
        {
            slot.DetachMag();
        }
        GetComponent<OVRGrabbable>();
    }

    public void Drop ()
    {
        if(slot == null)
        {
            GetComponent<BoxCollider>().enabled = true;
            GetComponent<OVRGrabbable>().grabbedBy.gameObject.GetComponent<OVRGrabber>().ForceRelease(gameObject.GetComponent<OVRGrabbable>());
        }
    }
  
}
