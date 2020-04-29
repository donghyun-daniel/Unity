using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float speed = 2.0f;
    Vector3 movement;
    Animator anim;
    Rigidbody CharacterRB;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        CharacterRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        movement = new Vector3(x, 0.0f, z).normalized * speed;
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        CharacterRB.velocity = movement;
        CharacterRB.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movement), 0.3f);
        if (movement.magnitude==0) anim.SetBool("IsWalk", false);
        else anim.SetBool("IsWalk", true);
    }
}
