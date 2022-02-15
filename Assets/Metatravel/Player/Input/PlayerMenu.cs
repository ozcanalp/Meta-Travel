using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMenu : MonoBehaviour
{
    public bool isMenuOpen = false;
    public bool isComputerUIOpen = false;
    [SerializeField] GameObject cursorManager;
    [SerializeField] GameObject crossHair;
    [SerializeField] GameObject stop;


    public void OnMenuInput(InputAction.CallbackContext context)
    {
        if (isComputerUIOpen)
        {
            return;
        }

        if(context.performed && !isMenuOpen)
        {
            cursorManager.GetComponent<CursorHide>().HideAndCenterCursor(false);
            crossHair.SetActive(false);
            stop.SetActive(true);
            isMenuOpen = true;
        }
        else if(context.performed && isMenuOpen)
        {
            cursorManager.GetComponent<CursorHide>().HideAndCenterCursor(true);
            crossHair.SetActive(true);
            stop.SetActive(false);
            isMenuOpen = false;
        }
    }
}
