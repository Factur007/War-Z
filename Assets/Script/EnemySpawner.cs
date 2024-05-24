using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject enemyPrefab; // префаб врага
    public int numberOfEnemies; // количество врагов для создания
    public float spawnRadius; // радиус спауна
    void Start()
    {
        {
            SpawnEnemies();
        }
    }

    void SpawnEnemies()
    {
        for (int i = 0; i < numberOfEnemies; i++)
        {
            Vector3 randomPosition = transform.position + Random.insideUnitSphere * spawnRadius;
            GameObject newEnemy = Instantiate(enemyPrefab, randomPosition, Quaternion.identity);
        }
    }
}
