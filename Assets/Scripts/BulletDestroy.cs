using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroy : MonoBehaviour
{
    public float timer1;
    public float timer2;
    public bool SELFDESTRUCT;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        timer1 += Time.deltaTime;
        if (SELFDESTRUCT)
        {
            timer2 += Time.deltaTime;
        }
        if (timer2 >= .1)
        {
            Destroy(gameObject);
        }
        if(timer1 >= 10)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        SELFDESTRUCT = true;
    }
}
