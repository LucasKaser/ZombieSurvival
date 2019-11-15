using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorChanger : MonoBehaviour
{
    private Animator Animator;
    // Start is called before the first frame update
    void Start()
    {
        Animator = GetComponent<Animator>();
    }

    private void OnCollisionEnter(Collision collision)
    {
       if(collision.gameObject.tag == "Player")
        {
            Animator.SetBool("Attacking", false);
            Debug.Log("Bruh");
        }else
        {
            Animator.SetBool("Attacking", true);
        }

            

        
    }

}
