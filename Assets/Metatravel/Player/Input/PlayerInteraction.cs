using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInteraction : MonoBehaviour
{
    [SerializeField] GameObject mainCamera;
    private Transform targetPosition;

    public bool isChangePosition = false;
    private float turnSpeed = 2;
    private Quaternion rotation;

    [SerializeField] GameObject cursorManager;
    [SerializeField] GameObject computerScreen;


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
                targetPosition = this.GetComponent<CameraRaycast>().whichButton.transform;
                rotation = this.GetComponent<CameraRaycast>().whichButton.transform.rotation;
                cursorManager.GetComponent<CursorHide>().HideAndCenterCursor(false);
                //computerScreen.SetActive(true);
                isChangePosition = true;
            }
        }
    }

    private void Update()
    {
        if (isChangePosition)
        {
            if(Mathf.Abs(mainCamera.transform.position.y - targetPosition.transform.position.y) < 0.1f)
            {  
                computerScreen.SetActive(true);
            }
            this.GetComponent<PlayerMenu>().isMenuOpen = true;
            this.GetComponent<PlayerMenu>().isComputerUIOpen = true;
            mainCamera.transform.rotation = Quaternion.Slerp(mainCamera.transform.rotation, Quaternion.Euler(10f, rotation.eulerAngles.y - 180f, rotation.eulerAngles.z), turnSpeed * Time.deltaTime);
            mainCamera.transform.position = Vector3.MoveTowards(mainCamera.transform.position, new Vector3(targetPosition.position.x, targetPosition.position.y, targetPosition.position.z), 2 * Time.deltaTime);
        }
    }
}
