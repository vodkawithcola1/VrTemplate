using System.Collections.Generic;
using UnityEngine;

public class FishSpawner : MonoBehaviour
{
    public GameObject fishPrefab;
    public Transform spawnPointsParent;  // Obiekt, którego dzieci będą punktami spawn

    private List<Transform> spawnPoints = new List<Transform>();
    private List<GameObject> spawnedFish = new List<GameObject>();
    private bool spawning = false;
    public float spawnInterval = 2f;

    void Awake()
    {
        // Pobierz wszystkie dzieci spawnPointsParent jako punkty spawn
        if (spawnPointsParent != null)
        {
            foreach (Transform child in spawnPointsParent)
            {
                spawnPoints.Add(child);
            }
        }
        else
        {
            Debug.LogWarning("Nie ustawiono spawnPointsParent! Dodaj obiekt w Inspectorze.");
        }
    }

    public void StartSpawning()
    {
        spawning = true;
        InvokeRepeating(nameof(SpawnFish), 0f, spawnInterval);
    }

    public void StopSpawning()
    {
        spawning = false;
        CancelInvoke(nameof(SpawnFish));
    }

    void SpawnFish()
    {
        if (!spawning) return;

        if (spawnPoints.Count == 0)
        {
            Debug.LogWarning("Brak punktów spawnu (dzieci spawnPointsParent).");
            return;
        }

        int index = Random.Range(0, spawnPoints.Count);
        GameObject fish = Instantiate(fishPrefab, spawnPoints[index].position, Quaternion.identity);
        spawnedFish.Add(fish);
    }

    public void DestroyAllFish()
    {
        foreach (GameObject fish in spawnedFish)
        {
            if (fish != null)
                Destroy(fish);
        }
        spawnedFish.Clear();
    }
}