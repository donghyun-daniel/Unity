using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
    Renderer myRenderer;
    public Color touchColor;
    Color orgColor;
    public bool isOverlaped = false;
    void Start()
    {
        myRenderer = GetComponent<Renderer>();
        orgColor = myRenderer.material.color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Endpoints")
        {
            myRenderer.material.color = touchColor;
            isOverlaped = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Endpoints")
        {
            myRenderer.material.color = orgColor;
            isOverlaped = false;
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Endpoints")
        {
            myRenderer.material.color = touchColor;
            isOverlaped = true;
        }
    }
}
