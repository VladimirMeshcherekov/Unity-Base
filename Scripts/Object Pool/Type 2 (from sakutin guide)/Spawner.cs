using System.Collections;
using UnityEngine;

public class EnemySpawner : ObjectPool
{
    [SerializeField] private GameObject[] prefabs;
    [SerializeField] private Transform spawnPoint;
    private void Start()
    {
        Initialize(prefabs);
        TrySpawnEnemy();
    }

    private void TrySpawnEnemy()
    {
        if (TryGetObject(out GameObject enemy))
        {
            SetEnemy(enemy);
        }
    }

    private void SetEnemy(GameObject enemy)
    {
        enemy.SetActive(true);
        enemy.transform.position = spawnPoint.position;
    }
}