using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody playerRigidbody;

    float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Selected Key at Input Manger
        float inputX = Input.GetAxis("Horizontal");
        float inputZ = Input.GetAxis("Vertical");
        float fallSpeed = playerRigidbody.velocity.y;
        Vector3 velocity = new Vector3(inputX, 0, inputZ);
        velocity = velocity * speed;
        velocity.y = fallSpeed;
        playerRigidbody.velocity = velocity;
    }
}
