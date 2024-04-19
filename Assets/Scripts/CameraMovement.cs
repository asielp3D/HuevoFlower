using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
   
   [SerializeField] private Camera cam;

   private Vector3 previousPosition;
   
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            previousPosition = cam.ScreenToViewportPoint(Input.mousePosition);
        }

        if (Input.GetMouseButton(0))
        {
            Vector3 direction = previousPosition - cam.ScreenToViewportPoint(Input.mousePosition);

            cam.transform.RotateAround(new Vector3(), new Vector3(1,0,0), direction.y * 0);
            cam.transform.RotateAround(new Vector3(), new Vector3(0,1,0), -direction.x * 180);

            previousPosition = cam.ScreenToViewportPoint(Input.mousePosition);
        }
    }
}
