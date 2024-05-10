using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EggDestruction2 : MonoBehaviour
{
    [SerializeField] private float explosiveForce = 100f;
    [SerializeField] private float explosiveRadius = 2f;
    [SerializeField] private float pieceFadeSpeed = 0.25f;
    [SerializeField] private float pieceDestroyDelay = 5f;
    [SerializeField] private float pieceSleepCheckDelay = 0.5f;
    [SerializeField]private GameObject _animalPrefab;

    void Start()
    {
        StartCoroutine(ExplodeCoroutine());
    }

    public IEnumerator ExplodeCoroutine()
    {
        Instantiate(_animalPrefab, transform.position, transform.rotation);
        
        Rigidbody[] pieces = GetComponentsInChildren<Rigidbody>();

        foreach (Rigidbody body in pieces)
        {
            body.AddExplosionForce(explosiveForce, transform.position, explosiveRadius);
        }

        yield return FadeOutRigidBodies(pieces);
    }

    private IEnumerator FadeOutRigidBodies(Rigidbody[] pieces)
    {
        WaitForSeconds wait = new WaitForSeconds(pieceSleepCheckDelay);
        int activeRigidBodies = pieces.Length;

        while (activeRigidBodies > 0)
        {
            yield return wait;

            foreach (Rigidbody body in pieces)
            {
                if (body.IsSleeping())
                {
                    activeRigidBodies--;
                }
            }

            yield return new WaitForSeconds(pieceDestroyDelay);

            Renderer[] renderers = Array.ConvertAll(pieces, body => body.GetComponent<Renderer>());

            foreach (Rigidbody body in pieces)
            {
                Destroy(body.GetComponent<Collider>());
                Destroy(gameObject);
            }

            float time = 0f;
            while (time < 1f)
            {
                float step = Time.deltaTime * pieceFadeSpeed;

                foreach (Renderer renderer in renderers)
                {
                    renderer.transform.Translate(Vector3.down * (step / renderer.bounds.size.y), Space.World);
                }

                time += step;
                yield return null;
            }

            foreach (Renderer renderer in renderers)
            {
                Destroy(renderer.gameObject);
            }

            Destroy(gameObject);
        }
    }
}
