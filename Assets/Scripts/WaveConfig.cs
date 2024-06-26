using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Wave Config", fileName = "New Wave Config")] 
public class WaveConfigSO : ScriptableObject
{
    [SerializeField] Transform pathPrefab;
    [SerializeField] List<GameObject> enemyPrefabs;
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] float timeBetweenSpawns = 1f;
    [SerializeField] float spawnTimeVar = 0.5f;
    [SerializeField] float minSpawnTime = 0.2f;

    public int GetEnemyCount()
    {
        return enemyPrefabs.Count;
    }

    public GameObject GetEnemyPrefab(int index)
    {
        return enemyPrefabs[index];
    }

    public Transform GetStartingWaypoint()
    {
        return pathPrefab.GetChild(0);
    }

    public List<Transform> GetWaypoints()
    {
        List<Transform> waypoints = new List<Transform>();
        foreach(Transform child in pathPrefab)
        {
            waypoints.Add(child);
        }
        return waypoints;
    }

    public float GetMoveSpeed()
    {
        return moveSpeed;
    }

    public float GetRandomSpawnTime()
    {
        float spawnTime = Random.Range(timeBetweenSpawns - spawnTimeVar,
                                        timeBetweenSpawns + spawnTimeVar);
        return Mathf.Clamp(spawnTime, minSpawnTime, float.MaxValue);
    }


}

