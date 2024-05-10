using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damag : MonoBehaviour
{
    public int Damage;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<HPSistem>())
        {
            other.GetComponent<HPSistem>().TakeDamage(Damage);
        }
    }
}
