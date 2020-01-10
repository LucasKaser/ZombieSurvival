﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullAuto : MonoBehaviour
{

    public GameObject bulletPrefab;
    public GameObject casingPrefab;
    public GameObject muzzleFlashPrefab;
    public Transform barrelLocation;
    public Transform casingExitLocation;
    public AudioSource bang;
    public AudioClip bang2;
    public float shotPower = 100f;
    public bool shoot;

    //ui says no ammo or audio making empty click
    //public GameObject noAmmo;
    bool noAmmoRunning = false;


    void Start()
    {
        if (barrelLocation == null)
            barrelLocation = transform;
    }

    public void TriggerShoot()
    {
        GetComponent<Animator>().SetBool("Fire", true);
        
    }
    public void stopShoot()
    {
        GetComponent<Animator>().SetBool("Fire", false);
    }
    private void Update()
    {
        if (shoot)
        {
            GetComponent<Animator>().SetBool("Fire", true);
        }
        if (!shoot)
        {
            GetComponent<Animator>().SetBool("Fire", false);
        }
        /*if (noAmmoRunning)
        {
            noAmmo.SetActive(true);
        }
        if (!noAmmoRunning)
        {
            noAmmo.SetActive(false);
        }*/
    }


    void Shoot()
    {





        //  GameObject bullet;
        //  bullet = Instantiate(bulletPrefab, barrelLocation.position, barrelLocation.rotation);
        // bullet.GetComponent<Rigidbody>().AddForce(barrelLocation.forward * shotPower);
        if (GetComponent<MagAttach>().magIn == true && GetComponentInChildren<AmmoScript>().ammoCount > 0)
        {
            GameObject tempFlash;
            Instantiate(bulletPrefab, barrelLocation.position, barrelLocation.rotation).GetComponent<Rigidbody>().AddForce(barrelLocation.forward * shotPower);
            tempFlash = Instantiate(muzzleFlashPrefab, barrelLocation.position, barrelLocation.rotation);
            bang.PlayOneShot(bang2);
            GetComponentInChildren<AmmoScript>().ammoCount -= 1;
        }
        else
        {
            noAmmoRunning = true;
        }
    }
            // Destroy(tempFlash, 0.5f);
            //  Instantiate(casingPrefab, casingExitLocation.position, casingExitLocation.rotation).GetComponent<Rigidbody>().AddForce(casingExitLocation.right * 100f);
        


    void CasingRelease()
    {
        if (GetComponent<MagAttach>().magIn == true && GetComponentInChildren<AmmoScript>().ammoCount > 0)
        {
            GameObject casing;
            casing = Instantiate(casingPrefab, casingExitLocation.position, casingExitLocation.rotation) as GameObject;
            casing.GetComponent<Rigidbody>().AddExplosionForce(550f, (casingExitLocation.position - casingExitLocation.right * 0.3f - casingExitLocation.up * 0.6f), 1f);
            casing.GetComponent<Rigidbody>().AddTorque(new Vector3(0, Random.Range(100f, 500f), Random.Range(10f, 1000f)), ForceMode.Impulse);
        }
    }


}
