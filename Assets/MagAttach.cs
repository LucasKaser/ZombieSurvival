﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MagAttach : MonoBehaviour
{
    public GameObject mag;
    //public GameObject reloader;
    public GameObject Gun;
    public GameObject Attach;
    public bool magIn = true;
    public string gunName;
    public Text ammoText;

    private void Start()
    {
        magIn = true;
        gunName = Gun.name;
    }

    private void Update()
    {
        if (mag.transform.parent == Gun)
        {
            Debug.Log("Mag is in");
            
            //mag.transform.position = Gun.transform.position + new Vector3(0, -0.03f, 0.14f);
            mag.transform.position = Attach.transform.position;
            magIn = true;
        }
        if (mag.transform.parent != Gun)
        {
            //magIn = false;
        }

        if(mag.transform.parent.gameObject == Gun)
        {
            ammoText.GetComponent<Text>().text = "" + mag.GetComponent<AmmoScript>().ammoCount + "/" + mag.GetComponent<AmmoScript>().ammoPool;
        }
        else
        {
            ammoText.GetComponent<Text>().text = "0/0";
        }
    }


    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Mag" && other.gameObject == mag)
        {
            if(other.gameObject.GetComponent<OVRGrabbable>().grabbedBy == null)
            {
                Debug.Log("WE COLLIDED");
                mag = other.gameObject;
                //mag.transform.position = M4.transform.position + new Vector3(0, -0.03f, 0.14f);
                other.transform.parent = transform;
                mag.transform.position = Attach.transform.position;
                mag.transform.rotation = Attach.transform.rotation;
                magIn = true;
                if (mag.transform.rotation != Gun.transform.rotation)
                {
                    //mag.transform.eulerAngles.x = Gun.transform.eulerAngles.x;

                }
                //that plus 270 on the x
            }

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Mag")
        {
            if (other.gameObject.GetComponent<OVRGrabbable>().grabbedBy != null)
            {
                magIn = false;

            }

        }
    }



}
