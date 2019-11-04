using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    public GameObject theEnemy;
    public int xPos;
    public int zPos;
    public int EnemyCount;

    void Start()
    {
        StartCoroutine(EnemyDrop());
    }
     IEnumerator EnemyDrop()
    {
        while (EnemyCount <8 )
        {
            xPos = Random.Range(1, 5);
            zPos = Random.Range(2, 5);
            Instantiate(theEnemy, new Vector3(xPos, 1, zPos), Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
            EnemyCount += 1;
        }
    }
    
}
