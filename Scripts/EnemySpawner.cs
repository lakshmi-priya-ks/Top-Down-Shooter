using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnRate = 2f;

    void Start()
    {
        InvokeRepeating("SpawnEnemy", 1f, spawnRate);
    }

    void SpawnEnemy()
    {
        float x = Random.Range(-8, 8);
        float y = Random.Range(4, 6);

        Instantiate(enemyPrefab, new Vector2(x, y), Quaternion.identity);
    }
}