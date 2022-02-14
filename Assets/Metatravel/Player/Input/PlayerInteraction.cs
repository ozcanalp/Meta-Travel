using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInteraction : MonoBehaviour
{
    [SerializeField] GameObject mainCamera;
    private Vector3 startPosition;
    private Transform targetPosition;

    private bool isChangePosition = false;
    private float turnSpeed = 2;
    private Quaternion defaultRotation;


    public void OnInteractionInput(InputAction.CallbackContext context)
    { 
        if (context.performed && this.GetComponent<CameraRaycast>().isHitButton)
        {

            if (this.GetComponent<CameraRaycast>().whichButton.CompareTag("Button1"))
            {
                //mainCamera.GetComponent<CameraRaycast>().whichButton.GetComponent<ButtonPressed>().Pressed();
                Debug.Log("1. button için url yi buraya yapýþtýr.");
            }
            else if (this.GetComponent<CameraRaycast>().whichButton.CompareTag("Button2"))
            {
                Debug.Log("2. button için url yi buraya yapýþtýr.");
            }
            else if (this.GetComponent<CameraRaycast>().whichButton.CompareTag("Computer"))
            {
                startPosition = mainCamera.transform.position;
                targetPosition = mainCamera.GetComponent<CameraRaycast>().whichButton.transform;
                defaultRotation = mainCamera.GetComponent<CameraRaycast>().whichButton.transform.rotation;
                isChangePosition = true;
            }
        }
    }

    private void Update()
    {
        if (isChangePosition)
        {
            this.GetComponent<PlayerMenu>().isMenuOpen = true;
            this.GetComponent<PlayerMenu>().isComputerUIOpen = true;
            mainCamera.transform.rotation = Quaternion.Slerp(mainCamera.transform.rotation, Quaternion.Euler(15,defaultRotation.eulerAngles.y - 180f, defaultRotation.eulerAngles.z), turnSpeed * Time.deltaTime);
            mainCamera.transform.position = Vector3.MoveTowards(mainCamera.transform.position, new Vector3(targetPosition.position.x, targetPosition.position.y, targetPosition.position.z), 2 * Time.deltaTime);
        }
    }
}
