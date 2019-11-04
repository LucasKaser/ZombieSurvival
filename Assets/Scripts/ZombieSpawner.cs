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
        while (EnemyCount <30 )
        {
            xPos = Random.Range(1, 9);
            zPos = Random.Range(1, 9);
            Instantiate(theEnemy, new Vector3(xPos, 1, zPos), Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
            EnemyCount += 1;
        }
    }
    
}
