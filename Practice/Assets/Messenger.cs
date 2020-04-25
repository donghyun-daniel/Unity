using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Messenger : MonoBehaviour
{
    public delegate void Send(string receiver);
    Send onSend;
    private void Start()
    {
        onSend += SendMail;
        onSend += SendMoney;
        onSend += (string man) =>
        {
            Debug.Log("Kill" + man);
            Debug.Log("Hide Body");
        };
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            onSend("Daniel");
        }
    }

    void SendMail(string reciever)
    {
        Debug.Log("Mail sent to : " + reciever);
    }

    void SendMoney(string reciever)
    {
        Debug.Log("Money sent to : " + reciever);
    }
}
