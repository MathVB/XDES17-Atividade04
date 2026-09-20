using UnityEngine;
using System.Collections.Generic;
using Random = UnityEngine.Random;

public class AsteroidSpawner : MonoBehaviour
{
    List<Transform> spawnPos;
    [SerializeField]  List<GameObject> asteroidsPrefabs;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    void Awake()
    {
        spawnPos = new List<Transform>();
        foreach (Transform child in transform)
        {
            spawnPos.Add(child);
        }
    }
    void SpawnAsteroids()
    {
        int spawnIndice = Random.Range(0,spawnPos.Count);
        int asteroideIndice = Random.Range(0, asteroidsPrefabs.Count);
        Instantiate(asteroidsPrefabs[asteroideIndice], 
            spawnPos[spawnIndice].position, 
            Quaternion.identity);
    }
    void Start()
    {
        InvokeRepeating("SpawnAsteroids", 0, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
