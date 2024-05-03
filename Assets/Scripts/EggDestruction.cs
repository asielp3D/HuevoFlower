using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EggDestruction : MonoBehaviour
{
    private Rigidbody rbody;
    [SerializeField] private GameObject brokenEgg;
    [SerializeField] private float explosiveForce = 100f;
    [SerializeField] private float explosiveRadius = 2f;
    [SerializeField] private float pieceFadeSpeed = 0.25f;
    [SerializeField] private float pieceDestroyDelay = 5f;
    [SerializeField] private float pieceSleepCheckDelay = 0.5f;

    private void Awake()
    {
        rbody = GetComponent<Rigidbody>();
    }

    public IEnumerator ExplodeCoroutine()
    {
        /*if (rbody != null)
        {
            Destroy(rbody);
        }*/

        Collider collider = GetComponent<Collider>();
        if (collider != null)
        {
            collider.enabled = false;
        }

        Renderer render = GetComponent<Renderer>();
        if (render != null)
        {
            render.enabled = false;
        }

        GameObject brokenInstance = Instantiate(brokenEgg, transform.position, transform.rotation);
        Rigidbody[] pieces = brokenInstance.GetComponentsInChildren<Rigidbody>();

        foreach (Rigidbody body in pieces)
        {
            if (rbody != null)
            {
                body.velocity = rbody.velocity;
            }

            body.AddExplosionForce(explosiveForce, transform.position, explosiveRadius);
        }

        Debug.Log("Bucle raruno acabao");

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

    private Renderer GetRendererFromRigidBody(Rigidbody rigidbody)
    {
        return rigidbody.GetComponent<Renderer>();
    }
}
