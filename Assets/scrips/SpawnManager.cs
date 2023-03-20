using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject EnemyPrefab;
    private float spawnRange =9.0f;
    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemyWave(3);
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    private Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(-spawnRange,spawnRange);
        float spawnPosZ = Random.Range(-spawnRange,spawnRange); 
        Vector3 randopos=new Vector3(spawnPosX,0,spawnPosZ);
        return randopos;
    }
    
    void SpawnEnemyWave(int enemiestospawn)
    {
        for(int i=0; i < enemiestospawn; i++)
        {
            Instantiate(EnemyPrefab,GenerateSpawnPosition(),EnemyPrefab.transform.rotation);
        }
    }
}
