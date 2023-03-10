using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    public GameObject spawnedObject;
    public bool stopSpawning = false;
    public float spawnTime;
    public float spawnDelay;

    // Start is called before the first frame update
    void Start(){
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
    }

    public void SpawnObject(){
        Instantiate(spawnedObject, transform.position, transform.rotation);
        if (stopSpawning){
            CancelInvoke("SpawnObject");
        }
    }
}
