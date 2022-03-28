using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawner : MonoBehaviour
{
    public GameObject enemyPrefab;

    int spawnRate;

    public Vector3 enemySpawnPoint;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Instantiate(enemyPrefab, enemySpawnPoint, Quaternion.identity);
    }
}
