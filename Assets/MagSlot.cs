using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagSlot : MonoBehaviour
{
    public Mag currentMag;

    public void AttachMag (Mag mag)
    {
        if (currentMag == null)
        {
            currentMag = mag;
            currentMag.slot = this;
        }
    }

    public void DetachMag ()
    {
        if (currentMag != null)
        {
            currentMag.slot = null;
            currentMag = null;
        }
    }



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
