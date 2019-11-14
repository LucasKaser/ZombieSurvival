using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class EnemyHp : MonoBehaviour
{
    public int health = 5;
    public Animator Enenmy;
    public GameObject Player;

    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Damage")
        {
            health--;
            Player.GetComponent<PlayerPoints>().points += 10;
        }
    }
    private void Update()
    {

        if (health <= 0)
        {
            GetComponent<Animator>().enabled = false;
            StartCoroutine(death());
            Player.GetComponent<PlayerPoints>().points += 50;

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
