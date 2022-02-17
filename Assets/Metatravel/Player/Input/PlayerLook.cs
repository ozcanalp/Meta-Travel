using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Photon.Pun;

public class PlayerLook : MonoBehaviour
{
    [SerializeField] PhotonView PV;

    [SerializeField] Camera playerCam;
    private float mouseSensivity = 250f;
    private float rotation = 0f;


    private void Start()
    {
        if (!PV.IsMine)
        {
            playerCam.gameObject.SetActive(false);
        }
    }

    private void Update()
    {
        if (PV.IsMine)
        {
            if (this.GetComponentInParent<PlayerMenu>().isMenuOpen)
                return;

            float mouseX = Input.GetAxis("Mouse X") * mouseSensivity * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * mouseSensivity * Time.deltaTime;

            rotation = rotation - mouseY;
            rotation = Mathf.Clamp(rotation, -90f, 90f);

            playerCam.transform.localRotation = Quaternion.Euler(rotation, 0f, 0f);
            transform.Rotate(Vector3.up * mouseX);
        }
    }
}
