using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagAttach : MonoBehaviour
{
    public GameObject mag;
    public GameObject M4;

    private void Start()
    {
        //mag.transform.parent = M4.transform;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Mag")
        {
            Debug.Log("WE COLLIDED");
            other.transform.parent = transform;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Mag")
        {
            Debug.Log("WE COLLIDED");
            collision.transform.parent = transform;
        }
    }







}
