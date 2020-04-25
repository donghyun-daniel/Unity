using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public delegate void Boost(Character target);
    public event Boost playerBoost;

    public string playerName = "Daniel";
    public float hp = 100;
    public float defense = 50;
    public float dmg = 30;
    // Start is called before the first frame update
    void Start()
    {
        playerBoost(this);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerBoost(this);
        }
        
    }
}
