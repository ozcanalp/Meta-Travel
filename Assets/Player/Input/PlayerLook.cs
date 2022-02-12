using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerLook : MonoBehaviour
{
    [SerializeField]private Transform playerTransform;
    private float mouseSensivity;
    private float rotation;

    private float mouseX;
    private float mouseY;

    private void Awake()
    {
        mouseSensivity = 320f;
        rotation = 0f;
    }

    private void FixedUpdate()
    {
        mouseX = Input.GetAxis("Mouse X") * mouseSensivity * Time.deltaTime;
        mouseY = Input.GetAxis("Mouse Y") * mouseSensivity * Time.deltaTime;

        rotation = rotation - mouseY;
        rotation = Mathf.Clamp(rotation, -90f, 90f);

        this.transform.localRotation = Quaternion.Euler(rotation, 0f, 0f);
        playerTransform.Rotate(Vector3.up * mouseX);
    }
}
