using Unity.VisualScripting;
using UnityEngine;

public class FishSpawner : MonoBehaviour
{
    public GameObject fishPrefab;
    public Transform spawnPointsParent;
    public float spawnInterval = 3f;
    
    private Transform[] spawnPoints;

    void Start()
    {
        // Pobieramy wszystkie dzieci jako spawnpointy
        spawnPoints = new Transform[spawnPointsParent.childCount];
        for (int i = 0; i < spawnPoints.Length; i++)
        {
            spawnPoints[i] = spawnPointsParent.GetChild(i);
        }
        
       
    }

    public void StartSpawning()
    {
        InvokeRepeating(nameof(SpawnFish), 3f, spawnInterval);
    }

    void SpawnFish()
    {
        if (spawnPoints.Length == 0) return;

        Transform spawn = spawnPoints[Random.Range(0, spawnPoints.Length)];
        Instantiate(fishPrefab, spawn.position, spawn.rotation);
    }
}