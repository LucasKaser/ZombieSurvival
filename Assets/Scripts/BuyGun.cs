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
        if (ovrgrabbable.isGrabbed && playerpoints >= cost)
        {
            Instantiate(Gun, transform.position, Quaternion.identity);
        }
    }
}
