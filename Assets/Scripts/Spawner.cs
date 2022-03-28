using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawner : MonoBehaviour
{
    ObjectPooler objectPooler;

    // Start is called before the first frame update
    void Start()
    {
        objectPooler = ObjectPooler.Instance;

        StartCoroutine(SpawnEnemies());
    }

    // Update is called once per frame
    IEnumerator SpawnEnemies()
    {
        while (true)
        {
            objectPooler.SpawnFromPool("Enemy", transform.position, Quaternion.identity);
            yield return new WaitForSeconds(3f);
        }
        
    }
}
