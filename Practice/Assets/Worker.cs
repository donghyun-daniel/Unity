using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Worker : MonoBehaviour
{
    Action work;

    void MoveBricks()
    {
        Debug.Log("벽돌옮김");
    }
    void Dig()
    {
        Debug.Log("땅팜");
    }
    // Start is called before the first frame update
    void Start()
    {
        work += MoveBricks;
        work += Dig;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            work();
        }
        
    }
}
