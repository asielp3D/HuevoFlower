using System.Collections;
using UnityEngine;

public class RandomPatrol : MonoBehaviour
{
    public float moveSpeed = 3f;
    public float changeDirectionInterval = 2f;
    public float areaSize = 10f;

    private Vector3 moveDirection;

    void Start()
    {
        // Comenzar a cambiar de dirección de forma periódica
        StartCoroutine(ChangeDirectionRoutine());
    }

    void Update()
    {
        Move();
    }

    private void Move()
    {
        // Mover el NPC en la dirección actual
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);

        // Asegurar que el NPC se quede dentro de los límites
        Vector3 newPosition = transform.position;
        newPosition.x = Mathf.Clamp(newPosition.x, -areaSize, areaSize);
        newPosition.z = Mathf.Clamp(newPosition.z, -areaSize, areaSize);
        transform.position = newPosition;
    }

    private IEnumerator ChangeDirectionRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(changeDirectionInterval);
            ChangeDirection();
        }
    }

    private void ChangeDirection()
    {
        // Cambiar la dirección a un vector aleatorio en el plano XZ
        float randomAngle = Random.Range(0f, 360f);
        moveDirection = new Vector3(Mathf.Cos(randomAngle), 0, Mathf.Sin(randomAngle)).normalized;
    }
}
