using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotaetToMouse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        Vector3 targetPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        float tempX = transform.eulerAngles.x;

        transform.LookAt(targetPosition, Vector3.up);
        transform.eulerAngles = new Vector3(tempX, transform.eulerAngles.y, transform.eulerAngles.z);
    }
}
