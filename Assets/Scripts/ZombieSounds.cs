using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSounds : MonoBehaviour
{
    public float timer;
    public AudioSource zombie;
    public AudioClip clip1;
    public AudioClip clip2;
    public AudioClip clip3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 5)
        {
            timer = 0;
            int i = Random.Range(1, 4);
            if(i == 1)
            {
                zombie.PlayOneShot(clip1);
            }
            if (i == 2)
            {
                zombie.PlayOneShot(clip2);
            }
            if (i == 1)
            {
                zombie.PlayOneShot(clip3);
            }
        }
    }
}
