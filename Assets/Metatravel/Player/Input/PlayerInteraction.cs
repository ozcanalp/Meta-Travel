using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class PlayerInteraction : MonoBehaviour
{
    [SerializeField] GameObject mainCamera;
    private Transform targetPosition;

    public bool isChangePosition = false;
    private float turnSpeed = 2;
    private Quaternion rotation;

    [SerializeField] GameObject cursorManager;
    [SerializeField] GameObject cameraPosition;
    [SerializeField] GameObject crossHair;
    private GameObject exit;
    private GameObject emptyGameObject;

    private bool setCameraToPosition = false;

    private void Awake()
    {
        exit = GameObject.Find("/Efe/Computer/Canvas/Exit");
    }
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
                crossHair.SetActive(false);
                //computerScreen.SetActive(true);
                //this.GetComponent<CameraRaycast>().whichButton;
                this.GetComponent<CameraRaycast>().whichButton.GetComponentInChildren<Canvas>().worldCamera = this.GetComponentInChildren<Camera>();
                isChangePosition = true;
            }
        }
    }

    private void Update()
    {
        if (isChangePosition)
        {
            if (Mathf.Abs(mainCamera.transform.position.y - targetPosition.position.y) < 0.05f)
            {
                mainCamera.transform.position = targetPosition.position;
                mainCamera.transform.rotation = Quaternion.Euler(10f, rotation.eulerAngles.y - 180f, rotation.eulerAngles.z);
                isChangePosition = false;
            }

            this.GetComponent<PlayerMenu>().isMenuOpen = true;
            this.GetComponent<PlayerMenu>().isComputerUIOpen = true;
            mainCamera.transform.rotation = Quaternion.Slerp(mainCamera.transform.rotation, Quaternion.Euler(10f, rotation.eulerAngles.y - 180f, rotation.eulerAngles.z), turnSpeed * Time.deltaTime);
            mainCamera.transform.position = Vector3.MoveTowards(mainCamera.transform.position, new Vector3(targetPosition.position.x, targetPosition.position.y, targetPosition.position.z), 2 * Time.deltaTime);
        }
        //GameObject asd = this.GetComponent<CameraRaycast>().whichButton.gameObject.transform.Find("Exit");
        if (exit.GetComponent<ButtonExit>().close)
        {
            this.GetComponent<PlayerMenu>().isMenuOpen = false;
            this.GetComponent<PlayerMenu>().isComputerUIOpen = false;
            this.GetComponent<PlayerInteraction>().isChangePosition = false;
            cursorManager.GetComponent<CursorHide>().HideAndCenterCursor(true);
            crossHair.SetActive(true);
            setCameraToPosition = true;
            exit.GetComponent<ButtonExit>().SetCloseFalse();
            this.GetComponent<CameraRaycast>().whichButton.GetComponentInChildren<Canvas>().worldCamera = null;
        }

        if (setCameraToPosition)
        {
            if (Mathf.Abs(mainCamera.transform.position.y - cameraPosition.transform.position.y) < 0.05f)
            {
                mainCamera.transform.position = cameraPosition.transform.position;
                setCameraToPosition = false;
            }

            mainCamera.transform.rotation = Quaternion.Slerp(mainCamera.transform.rotation, rotation, turnSpeed * Time.deltaTime);
            mainCamera.transform.position = Vector3.MoveTowards(mainCamera.transform.position, cameraPosition.transform.position, 2 * Time.deltaTime);
        }
    }
}
