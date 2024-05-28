using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{

    [SerializeField] protected int health;

    // Start is called before the first frame update
    void Start()
    {
        HealthEnemy(100);
    }

    public void HealthEnemy(int coint)
    {
        health = health + coint;
    }

    

    // Update is called once per frame
    void Update()
    {
      

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

}
