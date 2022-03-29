using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawner : MonoBehaviour
{
    ObjectPooler objectPooler;

    bool _spawnEnemies = true;

    public float spawnTime;
    public float spawnDelay;

    // Start is called before the first frame update
    void Start()
    {
        objectPooler = ObjectPooler.Instance;

        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
        
        //StartCoroutine(SpawnEnemies());
    }


    private void SpawnObject()
    {
       if (_spawnEnemies == true)
        {
            
           objectPooler.SpawnFromPool("Enemy", transform.position, Quaternion.identity);
            //StartCoroutine(DelaySpawn());
        }
    }

   


    
    //IEnumerator SpawnEnemies()
    //{
     //   while (_spawnEnemies == true)
     //  {
         
     //       ObjectPooler.Instance.SpawnFromPool("Enemy", transform.position, Quaternion.identity);
     //       yield return new WaitForSeconds(3f);
     //   }
        
    //}
}
