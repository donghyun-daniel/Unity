using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerHealth : MonoBehaviour
{
    public UnityEvent onPlayerDead;
    public void Dead()
    {
        onPlayerDead.Invoke();
        Destroy(gameObject);
    }
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        Dead();
    }
}
