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

    public float timeBetweenWaves = 5;
    public float waveCountDown;
    public float waveNumber;
    public Text waveCounter;

    public SpawnState state = SpawnState.COUNTING;

    private void Start()
    {
        waveCountDown = timeBetweenWaves;
    }

    void Update()
    {
        if (waveCountDown <= 0)
        {
            if (state != SpawnState.SPAWNING)
            {
                StartCoroutine(SpawnWave(waves[nextWave]));
                
            }
            waveCounter.text = "" + waveNumber;
                
               
            

        }
        else
        {
            waveCountDown -= Time.deltaTime;
        }
        
        

       
    }
    IEnumerator SpawnWave( Wave _wave)
    {
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
    }


     
}
