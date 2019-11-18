using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHP : MonoBehaviour
{
    public int health = 5;
    public GameObject Enemy;

    private void OnTriggerEnter(Collider other)
    {
        if(gameObject == Enemy)
        {
            health--;
        }
    }

    private void OnCollisionStay(Collision collision)
   {
        if(gameObject == Enemy)
        {
            health--;
        }
    }

}
