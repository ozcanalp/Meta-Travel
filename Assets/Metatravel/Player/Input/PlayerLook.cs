using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerLook : MonoBehaviour
{
    [SerializeField]private Transform playerTransform;
    private float mouseSensivity = 250f;
    private float rotation = 0f;

    private void Update()
    {
        if (this.GetComponentInParent<PlayerMenu>().isMenuOpen)
            return;

        float mouseX = Input.GetAxis("Mouse X") * mouseSensivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensivity * Time.deltaTime;

        rotation = rotation - mouseY;
        rotation = Mathf.Clamp(rotation, -90f, 90f);

        this.transform.localRotation = Quaternion.Euler(rotation, 0f, 0f);
        playerTransform.Rotate(Vector3.up * mouseX);
    }
}
