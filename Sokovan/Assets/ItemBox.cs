using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
    Renderer myRenderer;
    public Color touchColor;
    Color orgColor;
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
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Endpoints")
        {
            myRenderer.material.color = orgColor;
        }
    }
}
