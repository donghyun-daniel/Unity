using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public enum State
    {
        Idle, Ready, Tracking
    }
    State state //value is state when the state is changed
    {
        set
        {
            switch (value)
            {
                case State.Idle:
                    targetZoomSize = roundReadyZoomSize;
                    break;
                case State.Ready:
                    targetZoomSize = readyShotZoomSize;
                    break;
                case State.Tracking:
                    targetZoomSize = trackingZoomSize;
                    break;
            }
        }
    }

    Transform target;

    float smoothTime = 0.3f;

    Vector3 lastMovingVelocity;

    Vector3 targetPosition;
    Camera cam;
    float targetZoomSize = 8f;
    const float roundReadyZoomSize = 16f;
    const float readyShotZoomSize = 8f;
    const float trackingZoomSize = 11f;

    float lastZoomSpeed;

    private void Awake()
    {
        cam = GetComponentInChildren<Camera>();
        state = State.Idle;
    }

    private void Move()
    {
        targetPosition = target.transform.position;
        Vector3 smoothPostion = Vector3.SmoothDamp(transform.position, targetPosition, 
            ref lastMovingVelocity, smoothTime);
        transform.position = targetPosition;
        
    }

    // Start is called before the first frame update
    void Zoom()
    {
        float smoothZoomSize = Mathf.SmoothDamp(cam.orthographicSize, targetZoomSize, 
            ref lastZoomSpeed, smoothTime);
        cam.orthographicSize = smoothZoomSize;
    }

    private void FixedUpdate()
    {
        if (target != null)
        {
            Move();
            Zoom();
        }
    }

    public void Reset()
    {
        state = State.Idle;
    }
    public void SetTarget(Transform newTarget, State newState)
    {
        target = newTarget;
        state = newState;
    } 
}
