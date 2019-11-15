using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMove : MonoBehaviour
{
    NavMeshAgent agent;
    public GameObject player;
    public float chaseDistance = 10;
    private Vector3 home;
   



    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("Player");
        home = transform.position;
        agent = GetComponent<NavMeshAgent>();
        
    }

   
    // Update is called once per frame
    void Update()
    {
        Vector3 direction = player.transform.position - transform.position;
        if(direction.magnitude <= chaseDistance)
        {
            agent.destination = player.transform.position;
        }
        else
        {
            agent.destination = home;
        }
      

        

    }
}
