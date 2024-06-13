using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] List<WaveConfigSO> waveConfigs;
    [SerializeField] float timeBetweenWaves = 0f;
    [SerializeField] bool isLoop;
    WaveConfigSO currWave;

    
    void Start()
    {
        StartCoroutine(SpawnEnemyWaves());
    }

    public WaveConfigSO GetCurrWave()
    {
        return currWave;
    }

    IEnumerator SpawnEnemyWaves()
    {
        do 
        {
            foreach (WaveConfigSO wave in waveConfigs)
            {
                currWave = wave;
                for (int i = 0; i < currWave.GetEnemyCount(); i++)
                {
                    Instantiate(currWave.GetEnemyPrefab(i),
                                currWave.GetStartingWaypoint().position,
                                Quaternion.Euler(0, 0, 180),
                                transform);
                    yield return new WaitForSeconds(currWave.GetRandomSpawnTime());
                }
                yield return new WaitForSeconds(timeBetweenWaves);
            }
        }
        while(isLoop);

    }
}
