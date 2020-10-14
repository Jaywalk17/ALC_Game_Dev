using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    
    private float spawnRangeX = 20;
    private float spawnposZ = -10;

    // Update is called once per frame
    void Update()
    {
        // Randomizes animal index and spawn location
        if (Input.GetKeyDown(KeyCode.S)){
            SpawnRandomAnimal();
        }

    }
    void SpawnRandomAnimal(){
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnposZ);

        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
