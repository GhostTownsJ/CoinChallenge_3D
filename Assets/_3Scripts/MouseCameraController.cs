using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCameraController : MonoBehaviour
{
    [SerializeField] private float mouseSensitivity;

    private Transform parent; 

    private void Start()
    {
        parent = transform.parent;
    }

    private void Update()
    {
        Rotate();
    }

    private void Rotate()
    {
        float mouseXAxis = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        
        parent.Rotate(Vector3.up, mouseXAxis);
    }
}
