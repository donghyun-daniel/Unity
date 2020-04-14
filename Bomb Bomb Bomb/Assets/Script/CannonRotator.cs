﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonRotator : MonoBehaviour
{
    enum RotateState
    {
        Idle, Horizontal, Vertical, Ready
    }

    RotateState state = RotateState.Idle;
    public float verticalRotateSpeed = 180f;
    public float horizontalRotateSpeed = 180f;

    public Cannon cannon;

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (state)
        {
            case RotateState.Idle:
                if (Input.GetButtonDown("Fire1"))
                {
                    state = RotateState.Horizontal;
                }
                break;
            case RotateState.Horizontal:
                if (Input.GetButton("Fire1"))
                {
                    transform.Rotate(new Vector3(0, horizontalRotateSpeed * Time.deltaTime, 0));
                }
                else if (Input.GetButtonUp("Fire1"))
                {
                    state = RotateState.Vertical;
                }
                break;

            case RotateState.Vertical:
                if (Input.GetButton("Fire1"))
                {
                    transform.Rotate(new Vector3(-verticalRotateSpeed * Time.deltaTime, 0, 0));
                }
                else if (Input.GetButtonUp("Fire1"))
                {
                    state = RotateState.Ready;
                    cannon.enabled = true;
                }
                break;
            case RotateState.Ready:
                state = RotateState.Ready;
                cannon.enabled = true;
                break;
        }
    }


    private void OnEnable()
    {
        transform.rotation = Quaternion.identity; //It mean 0,0,0 rotation
        state = RotateState.Idle;
        cannon.enabled = false;
    }
}
