using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public Rigidbody RigidbodyCharacter;
    float force = 200f;
    void Start()
    {
        RigidbodyCharacter = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputZ = Input.GetAxis("Vertical");
        float fallSpeed = RigidbodyCharacter.velocity.y;
        RigidbodyCharacter.AddForce(inputX*force, 0, inputZ*force);

    }
}
