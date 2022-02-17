using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Photon.Pun;

public class PlayerInteraction : MonoBehaviour
{
    [SerializeField] PhotonView PV;

    [SerializeField] GameObject mainCamera;
    [SerializeField] GameObject cursorManager;
    [SerializeField] GameObject cameraPosition;
    [SerializeField] GameObject crossHair;
    
    private GameObject exit;
    private Transform targetPosition;

    private Quaternion rotation;
    private float turnSpeed = 2;


    private bool setCameraToComputer = false;
    private bool setCameraToPlayer = false;

    private bool flagComputer = false;


    private void Awake()
    {
        exit = GameObject.Find("/Efe/Computer/Canvas/Exit");
    }

    public void OnInteractionInput(InputAction.CallbackContext context)
    { 
        if (context.performed && this.GetComponent<CameraRaycast>().isHitButton)
        {
            if (this.GetComponent<CameraRaycast>().whichButton.CompareTag("Ring"))
            {
                this.GetComponent<ShowReceptionistDialog>().SetShow();
            }
            else if (this.GetComponent<CameraRaycast>().whichButton.CompareTag("Computer"))
            {
                flagComputer = true;
            }
        }
    }

    private void Update()
    {
        if (PV.IsMine)
        {
            PressComputerWithRaycast();

            SetCameraPositionToComputer();

            PressExitButtonOnComputer();

            SetCameraPositionToPlayer();
        } 
    }

    private void PressComputerWithRaycast()
    {
        if (flagComputer)
        {
            targetPosition = this.GetComponent<CameraRaycast>().whichButton.transform;
            rotation = this.GetComponent<CameraRaycast>().whichButton.transform.rotation;
            cursorManager.GetComponent<CursorHide>().HideAndCenterCursor(false);
            //computerScreen.SetActive(true);
            //this.GetComponent<CameraRaycast>().whichButton;
            setCameraToComputer = true;
            flagComputer = false;
        }
    }

    private void SetCameraPositionToComputer()
    {
        if (setCameraToComputer)
        {
            if (Mathf.Abs(mainCamera.transform.position.y - targetPosition.position.y) < 0.05f)
            {
                mainCamera.transform.position = targetPosition.position;
                mainCamera.transform.rotation = Quaternion.Euler(10f, rotation.eulerAngles.y - 180f, rotation.eulerAngles.z);
                this.GetComponent<CameraRaycast>().whichButton.GetComponentInChildren<Canvas>().worldCamera = this.GetComponentInChildren<Camera>();
                setCameraToComputer = false;
            }
            crossHair.SetActive(false);
            this.GetComponent<PlayerMenu>().isMenuOpen = true;
            this.GetComponent<PlayerMenu>().isComputerUIOpen = true;
            mainCamera.transform.rotation = Quaternion.Slerp(mainCamera.transform.rotation, Quaternion.Euler(10f, rotation.eulerAngles.y - 180f, rotation.eulerAngles.z), turnSpeed * Time.deltaTime);
            mainCamera.transform.position = Vector3.MoveTowards(mainCamera.transform.position, new Vector3(targetPosition.position.x, targetPosition.position.y, targetPosition.position.z), 2 * Time.deltaTime);
        }
    }

    private void PressExitButtonOnComputer()
    {
        if (exit.GetComponent<ButtonExit>().close)
        {
            this.GetComponent<PlayerMenu>().isMenuOpen = false;
            this.GetComponent<PlayerMenu>().isComputerUIOpen = false;
            //this.GetComponent<PlayerInteraction>().setCameraToComputer = false;
            cursorManager.GetComponent<CursorHide>().HideAndCenterCursor(true);
            crossHair.SetActive(true);
            setCameraToPlayer = true;
            exit.GetComponent<ButtonExit>().SetCloseFalse();
            this.GetComponent<CameraRaycast>().whichButton.GetComponentInChildren<Canvas>().worldCamera = null;
        }
    }

    private void SetCameraPositionToPlayer()
    {
        if (setCameraToPlayer)
        {
            if (Mathf.Abs(mainCamera.transform.position.y - cameraPosition.transform.position.y) < 0.05f)
            {
                mainCamera.transform.position = cameraPosition.transform.position;
                setCameraToPlayer = false;
            }
            mainCamera.transform.rotation = Quaternion.Slerp(mainCamera.transform.rotation, rotation, turnSpeed * Time.deltaTime);
            mainCamera.transform.position = Vector3.MoveTowards(mainCamera.transform.position, cameraPosition.transform.position, 2 * Time.deltaTime);
        }
    }
}
