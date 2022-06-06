using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float startDelay = 2.0f;
    private float spawnInterval = 1.5f;
    private float spawnOuterRangeX = 3.0f;
    private float spawnInnerRangeX = 1.0f;
    private float spawnPosY = 2.0f;
    private float spawnPosZ = 9.0f;
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnInnerRangeX, spawnOuterRangeX), spawnPosY, -spawnPosZ);

        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
