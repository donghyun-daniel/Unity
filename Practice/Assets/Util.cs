using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Util : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Container<string> container = new Container<string>();
        container.msgs = new string[2];
        container.msgs[0] = "Hello";
        container.msgs[1] = "Bye";
        for(int i = 0; i < container.msgs.Length; i++)
        {
            Debug.Log(container.msgs[i]);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Print<T>(T inputMsg)
    {
        Debug.Log(inputMsg);
    }
    public class Container<T>
    {
        public T[] msgs;
    }
}
