using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBuy : MonoBehaviour
{
    public GameObject Player;
    private OVRGrabbable ovrgrabbable;
    public int playerpoints;
    public int cost;
    public GameObject Spawner;
    // Start is called before the first frame update
    void Start()
    {
        ovrgrabbable = GetComponent<OVRGrabbable>();
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        playerpoints = Player.GetComponent<PlayerPoints>().points;
        if(ovrgrabbable.isGrabbed && playerpoints >= cost)
        {
            Player.GetComponent<PlayerPoints>().points -= cost;
            Spawner.SetActive(true);
            Destroy(gameObject);
        }
        else
        {
            ovrgrabbable.grabbedBy.gameObject.GetComponent<OVRGrabber>().ForceRelease(gameObject.GetComponent<OVRGrabbable>());
        }

    }
}
