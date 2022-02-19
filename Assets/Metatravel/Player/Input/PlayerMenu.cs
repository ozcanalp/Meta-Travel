using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Photon.Pun;

public class PlayerMenu : MonoBehaviour
{
    [SerializeField] PhotonView PV;

    [SerializeField] GameObject cursorManager;
    [SerializeField] GameObject stop;
    [SerializeField] GameObject crossHair;
    [SerializeField] private GameObject panel;

    public bool isMenuOpen = false;
    public bool isComputerUIOpen = false;
    private bool flag = false;


    public void OnMenuInput(InputAction.CallbackContext context)
    {
        if (PV.IsMine)
        {
            if (isComputerUIOpen)
            {
                return;
            }

            if (context.performed)
            {
                flag = true;
                panel.SetActive(false);
            }
        }
    }

    private void Update()
    {
        if (PV.IsMine)
        {
            if (flag)
            {
                if (!isMenuOpen)
                {
                    cursorManager.GetComponent<CursorHide>().HideAndCenterCursor(false);
                    crossHair.SetActive(false);
                    stop.SetActive(true);
                    isMenuOpen = true;
                    flag = false;
                }
                else if (isMenuOpen)
                {
                    cursorManager.GetComponent<CursorHide>().HideAndCenterCursor(true);
                    crossHair.SetActive(true);
                    stop.SetActive(false);
                    isMenuOpen = false;
                    flag = false;
                }
            }
        }    
    }
}
