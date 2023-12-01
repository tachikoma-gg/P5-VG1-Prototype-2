using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] animalPrefabs;
    [SerializeField] private float spawnRangeX = 20f;
    [SerializeField] private float spawnPositionZ = 20f;

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.P))
        {
            int animalIndex = Random.Range(0, animalPrefabs.Length);

            float x = Random.Range(-spawnRangeX, spawnRangeX);
            float y = 0;
            float z = spawnPositionZ;

            Vector3 spawnPosition = new Vector3(x, y, z);

            Instantiate(animalPrefabs[animalIndex], spawnPosition, animalPrefabs[animalIndex].transform.rotation);
        }
    }
}
