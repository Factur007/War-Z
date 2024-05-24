using System.Collections;
using System.Collections.Generic;
using UnityEngine;
    

public class Player : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 5f;
    public float gravite = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 move = transform.right * horizontal + transform.forward * vertical;
        move.y -= gravite;

        controller.Move(move * speed * Time.deltaTime);

    }
}
