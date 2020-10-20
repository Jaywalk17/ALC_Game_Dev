using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Creates array to house animals
    public GameObject[] animalPrefabs;
    
    private float spawnRangeX = 20;
    private float spawnposZ = -10;

    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start(){
        // Spawns animal
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    
    }
        
    // Update is called once per frame
    void Update()
    {

    }

    // Randomizes animal index and spawn location
    void SpawnRandomAnimal(){
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnposZ);

        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
