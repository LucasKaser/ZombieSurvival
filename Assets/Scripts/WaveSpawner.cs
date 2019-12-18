using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaveSpawner : MonoBehaviour
{
    public enum SpawnState { SPAWNING, WAITING, COUNTING};
    [System.Serializable]
  public class Wave
    {
        public string name;
        public Transform enemy;
        public int count;
        public float rate;
    }

    public Wave[] waves;
    private int nextWave = 0;
    public Transform[] spawnPoints;
    public List<Transform> isEnabled;

    public float timeBetweenWaves = 5;
    public float waveCountDown;
    public float waveNumber =1;
    public Text waveCounter;
    private float searchCountDown = 1f;

    public SpawnState state = SpawnState.COUNTING;

    private void Start()
    {
        waveCountDown = timeBetweenWaves;
        if (spawnPoints.Length == 0)
        {
            Debug.LogError("No spawn points");
        }
    }

    void Update()
    {
        if (waveCountDown <= 0)
        {
            if (state == SpawnState.WAITING)
            {
                //check if enemies are still alive
                if (!EnemyIsAlive())
                {
                    WaveCompleted();
                    return;
                        
                        }

                else
                {
                    return;
                }
               



            }


            if (waveCountDown <= 0)
            {
                if (state != SpawnState.SPAWNING)
                {
                    
                    StartCoroutine(SpawnWave(waves[nextWave]));

                }
            }
            
               
              
           }
        else
        {
            waveCountDown -= Time.deltaTime;
        }

        for (int i = 0; i < spawnPoints.Length; i++)
        {
            if (spawnPoints[i].gameObject.activeSelf == true && !isEnabled.Contains(spawnPoints[i]))
            {
                isEnabled.Add(spawnPoints[i]);
            }
            else if(spawnPoints[i].gameObject.activeSelf == false /*&& isEnabled.Contains(spawnPoints[i])*/)
            {
                isEnabled.Remove(spawnPoints[i]);
            }
        }



        void WaveCompleted ()
        {
            Debug.Log("Wave Completed!");
            state = SpawnState.COUNTING;
            waveCountDown = timeBetweenWaves;
            waveNumber += 1;
            waveCounter.text = "" + waveNumber;
            if (nextWave + 1 > waves.Length - 1)
            {
                nextWave = 0;
                Debug.Log("all waves complete");
            }
            else
            {
                nextWave++;
            }
           
        }
       
    }
    bool EnemyIsAlive()
    {
        searchCountDown -= Time.deltaTime;
        if (searchCountDown <= 0f)
        {
            searchCountDown = 1f;
            if (GameObject.FindGameObjectWithTag("Zombie") == null)
            {
                return false;
            }
            return true;
        }

     
        return true;
    }

    IEnumerator SpawnWave( Wave _wave)
    {
        Debug.Log("Spawning Wave:" + _wave.name);
        state = SpawnState.SPAWNING;
        for (int i = 0; i < _wave.count; i++)
        {
            
            
            
            SpawnEnemy(_wave.enemy);
            yield return new WaitForSeconds(1f / _wave.rate);
           
        }
        state = SpawnState.WAITING;
        yield break;
        
    }
    void SpawnEnemy(Transform _enemy)
    {
        Debug.Log("Spawning ENemy: " + _enemy.name);
        if(spawnPoints.Length == 0)
        {
             
        }

        foreach (Transform g in isEnabled)
        {
            
        }
        Transform f = isEnabled[Random.Range(0, isEnabled.Count)];
        //Transform _sp = spawnPoints[Random.Range(0, spawnPoints.Length)];
        Instantiate(_enemy, f.position, f.rotation);

        
    
    }


     
}
