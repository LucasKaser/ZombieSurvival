using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{ 
    private Animator Animator;

    // Start is called before the first frame update
    void Start()
    {
        Animator = GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Animator.SetBool("Attacking", true);
            Debug.Log("Ligma moment"); 

        }
        else
        {
            Animator.SetBool("Attacking", false);

        }

    }
    private void OnTriggerExit(Collider collision)
    {
         if (collision.gameObject.tag == "Player")
        {
            Animator.SetBool("Attacking", true);
            Debug.Log("Bruh moment");
        }
        else
        {
            Animator.SetBool("Attacking", false);

        }
    }
    private void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Animator.SetBool("Attacking", false);
            Debug.Log("H moment");
        }

    }
    


}
