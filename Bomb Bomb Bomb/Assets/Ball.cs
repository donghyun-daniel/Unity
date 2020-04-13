using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public LayerMask whatIsProp;
    public ParticleSystem explosionParticle;
    public AudioSource explosionAudio;
    public float maxDamage = 100f;
    public float explosionForce = 100f;
    public float lifeTime = 10f;
    public float explosionRadius = 10f;

    void Start()
    {
        Destroy(gameObject, lifeTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, explosionRadius, whatIsProp);
        explosionParticle.transform.parent = null;
        explosionParticle.Play();
        explosionAudio.Play();
        Destroy(explosionParticle.gameObject, explosionParticle.duration);
        Destroy(gameObject);
    }

    float CalculateDamage(Vector3 targetPosition)
        {
            return 0.1f;
        }
}
