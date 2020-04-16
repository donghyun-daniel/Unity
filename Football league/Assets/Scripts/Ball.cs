using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody RigidbodyBall;
    // Start is called before the first frame update
    void Start()
    {
        RigidbodyBall = GetComponent<Rigidbody>();
        RigidbodyBall.AddForce(1000, 0, 0);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
