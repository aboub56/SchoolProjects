using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] shapePrefabs;
    private float spawnRightZ = -20;
    private float spawnLeftZ = -10;
    private float spawnPosZ = 0;
    private float spawnPosY = 3.7f;
    private float startDelay = 2;
    private float spawnInterval = 2f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomShape", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomShape()
    {

        int shapeIndex = Random.Range(0, shapePrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(spawnLeftZ, spawnRightZ), Random.Range(-spawnPosY, spawnPosY), spawnPosZ);

        Instantiate(shapePrefabs[shapeIndex], spawnPos, shapePrefabs[shapeIndex].transform.rotation);
    }
}
