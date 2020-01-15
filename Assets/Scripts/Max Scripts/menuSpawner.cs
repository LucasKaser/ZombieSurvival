using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuSpawner : MonoBehaviour
{
    public GameObject spawnPoint;
    public GameObject enemy;
    public float time = 0.0f;
    public float firstTimer = 10.0f;
    public float timer = 5.0f;
    public bool firstSpawn = false;
    public bool enemyAlive = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(enemyAlive == false)
        {
            time += Time.deltaTime;
        }
        if(time >= firstTimer && firstSpawn == false && enemyAlive == false)
        {
            Instantiate(enemy, spawnPoint.transform);
            enemyAlive = true;
        }
        if(time >= timer && firstSpawn == true && enemyAlive == false)
        {
            Instantiate(enemy, spawnPoint.transform);
            enemyAlive = true;
        }
    }
}
