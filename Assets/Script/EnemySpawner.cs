using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject enemyPrefab; 
    public int numberOfEnemies;
    public float zRandValue = 5;
    public float xRandValue = 5;
    private int enemyCount;

    void Start()
    {
        
        SpawnEnemies();
        
    }

   
    void SpawnEnemies()
    {
        for (int i = 0; i < numberOfEnemies; i++)
        {
            Vector3 randomPosition = new Vector3(Random.Range( -xRandValue, xRandValue), 0, Random.Range( -zRandValue,zRandValue)) + transform.position;    
            GameObject newEnemy = Instantiate(enemyPrefab, randomPosition, Quaternion.identity);
        }
    }

    private void Update()
    {
        enemyCount = FindObjectsOfType<Wrag>().Length;
        if (enemyCount == 0 )
        {
            numberOfEnemies++;
            SpawnEnemies();
        }
    }
}
