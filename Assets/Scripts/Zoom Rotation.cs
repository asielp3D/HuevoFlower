using UnityEngine;

public class TouchController : MonoBehaviour
{
    private float rotationSpeed = 0.5f;
    private float zoomSpeed = 0.5f;

    private Vector2 prevTouchPos = Vector2.zero;

    void Update()
    {
        if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            // Rotar el objeto
            Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
            transform.Rotate(0, -touchDeltaPosition.x * rotationSpeed, 0);
        }

        if (Input.touchCount == 2)
        {
            // Hacer zoom en el objeto
            Touch touchZero = Input.GetTouch(0);
            Touch touchOne = Input.GetTouch(1);

            Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
            Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

            float prevTouchDeltaMag = (touchZeroPrevPos - touchOnePrevPos).magnitude;
            float touchDeltaMag = (touchZero.position - touchOne.position).magnitude;

            float deltaMagnitudeDiff = prevTouchDeltaMag - touchDeltaMag;

            transform.localScale += new Vector3(deltaMagnitudeDiff * zoomSpeed, deltaMagnitudeDiff * zoomSpeed, deltaMagnitudeDiff * zoomSpeed);
        }
    }
}
