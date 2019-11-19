using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyGun : MonoBehaviour
{
    public GameObject Gun;
    public int cost;
    public int playerpoints;
    public GameObject Player;
    private OVRGrabbable ovrgrabbable;
    public float wait;

    // Start is called before the first frame update
    void Start()
    {
        ovrgrabbable = GetComponent<OVRGrabbable>();
        Player = GameObject.FindGameObjectWithTag("Player");
        
    }

    // Update is called once per frame
    void Update()
    {
        wait += Time.deltaTime;
        playerpoints = Player.GetComponent<PlayerPoints>().points;
        if (ovrgrabbable.isGrabbed && playerpoints >= cost)
        {
            wait = 0;
            Instantiate(Gun, transform.position, Quaternion.identity);
            Player.GetComponent<PlayerPoints>().points -= cost;
            ovrgrabbable.grabbedBy.gameObject.GetComponent<OVRGrabber>().ForceRelease(gameObject.GetComponent<OVRGrabbable>());
        }
        else
        {
            ovrgrabbable.grabbedBy.gameObject.GetComponent<OVRGrabber>().ForceRelease(gameObject.GetComponent<OVRGrabbable>());
        }
    }
}
