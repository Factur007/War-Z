using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject enemyPrefab; 
    public int numberOfEnemies;
    public float zRandValue = 5;
    public float xRandValue = 5;

    void Start()
    {
        
        SpawnEnemies();
        
    }

    void SpawnEnemies()
    {
        for (int i = 0; i < numberOfEnemies; i++)
        {
            Vector3 randomPosition = new Vector3(Random.Range( -xRandValue, xRandValue), 0, Random.Range( -zRandValue,zRandValue));    
            GameObject newEnemy = Instantiate(enemyPrefab, randomPosition, Quaternion.identity);
        }
    }
}
