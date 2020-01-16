using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupDelete : MonoBehaviour
{
    public float LifeTime = 30f;
    public float LifeTimer;

    // Update is called once per frame
    void Update()
    {
        LifeTimer += Time.deltaTime;
        if(LifeTimer >= LifeTime)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Destroy(gameObject, 0.1f);
        }
    }
}
