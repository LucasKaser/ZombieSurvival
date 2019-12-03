using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagAttach : MonoBehaviour
{
    public GameObject mag;
    public GameObject Gun;
    public GameObject Attach;


    private void Update()
    {
        if (mag.transform.parent != null)
        {
            //mag.transform.position = M4.transform.position + new Vector3(0, -0.03f, 0.14f);
            mag.transform.position = Attach.transform.position;
        }

    }
    
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Mag")
        {
            if(other.gameObject.GetComponent<OVRGrabbable>().grabbedBy == null)
            {
                Debug.Log("WE COLLIDED");
                mag = other.gameObject;
                //mag.transform.position = M4.transform.position + new Vector3(0, -0.03f, 0.14f);
                other.transform.parent = transform;
                //mag.transform.position = Attach.transform.position;
                Debug.Log(mag.transform.position);
            }

        }
    }







}
