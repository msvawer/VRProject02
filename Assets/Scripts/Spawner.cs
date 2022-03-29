using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawner : MonoBehaviour
{
    ObjectPooler objectPooler;

    bool _spawnEnemies = true;

    public float spawnTimer;

    // Start is called before the first frame update
    void Start()
    {
        objectPooler = ObjectPooler.Instance;

        spawnTimer = Time.time;

        //StartCoroutine(SpawnEnemies());
    }


    private void Update()
    {
        if (Time.time > spawnTimer + .1f)
        {
            spawnTimer = Time.time;
            objectPooler.SpawnFromPool("Enemy", transform.position, Quaternion.identity);
        }
    }

    // Update is called once per frame
    //IEnumerator SpawnEnemies()
    //{
      //  while (_spawnEnemies == true)
     //  {
      //     
            //objectPooler.SpawnFromPool("Enemy", transform.position, Quaternion.identity);
        //    yield return new WaitForSeconds(3f);
      //  }
        
    //}
}
