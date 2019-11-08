using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class EnemyHp : MonoBehaviour
{
    public int health = 5;
    public Animator Enenmy;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Damage")
            health--;

    }
    private void Update()
    {

        if (health <= 0)
        {
            GetComponent<Animator>().enabled = false;
            StartCoroutine(death());
        }

    }
    IEnumerator death()
    {
        while (true)
        {
            yield return new WaitForSeconds(10);
            Destroy(gameObject);




        }
    }
}
