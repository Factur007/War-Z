using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HPSistem : MonoBehaviour
{
    [SerializeField] Text HPext;
    int health;

    // Start is called before the first frame update
    void Start()
    {
        ChangeHealth(100);
    }

    public void ChangeHealth(int count)
    {
        health = Mathf.Max(health + count, 0);
        HPext.text = health.ToString();

        if (health <= 0)
        {
            Die();
        }
    }
    public void TakeDamage(int damage)
    {
        ChangeHealth(-damage);
    }

    void Die()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
