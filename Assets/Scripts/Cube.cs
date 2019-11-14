using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    
    private Animator animator;
    public GameObject player;
   

    void Start()
    {

        animator = GetComponentInParent<Animator>();
    }


   


    // Update is called once per frame
    void Update()
    {
     
    }

}
