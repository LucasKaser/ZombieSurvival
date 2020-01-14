using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBuy : MonoBehaviour
{
    public GameObject Player;
    private OVRGrabbable ovrgrabbable;
    public int playerpoints;
    public int cost;
    public GameObject[] Spawner;
    public GameObject otherside;
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
            for(int s = 0; s <= Spawner.Length - 1; s++)
            {
                Spawner[s].SetActive(true);
            }
            if(otherside != null)
            {
                Destroy(otherside);
            }
            Destroy(gameObject);
        }
        else
        {
            ovrgrabbable.grabbedBy.gameObject.GetComponent<OVRGrabber>().ForceRelease(gameObject.GetComponent<OVRGrabbable>());
        }

    }
}
