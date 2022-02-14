using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonExit : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject cursorManager;
    [SerializeField] GameObject computerScreen;
    [SerializeField] GameObject mainCamera;
    [SerializeField] GameObject cameraPosition;

    private bool setCameraToPosition = false;
    private float turnSpeed = 2;
    private Quaternion rotation;

    public void ExitComputer()
    {
        player.GetComponent<PlayerMenu>().isMenuOpen = false;
        player.GetComponent<PlayerMenu>().isComputerUIOpen = false;
        player.GetComponent<PlayerInteraction>().isChangePosition = false;
        cursorManager.GetComponent<CursorHide>().HideAndCenterCursor(true);
        setCameraToPosition = true;
        //computerScreen.SetActive(false);
        rotation = player.transform.rotation;
        
    }

    private void Update()
    {
        if (setCameraToPosition)
        {
            if (Mathf.Abs(mainCamera.transform.position.y - cameraPosition.transform.position.y) < 0.1f)
            {
                mainCamera.transform.position = cameraPosition.transform.position;
                setCameraToPosition = false;
                computerScreen.SetActive(false);
            }
            mainCamera.transform.rotation = Quaternion.Slerp(mainCamera.transform.rotation, rotation, turnSpeed * Time.deltaTime);
            mainCamera.transform.position = Vector3.MoveTowards(mainCamera.transform.position, cameraPosition.transform.position, 2 * Time.deltaTime);
        }   
    }
}
