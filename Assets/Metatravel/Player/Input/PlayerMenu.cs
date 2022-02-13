using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMenu : MonoBehaviour
{
    public bool isMenuOpen = false;
    [SerializeField] GameObject cursorManager;


    public void OnMenuInput(InputAction.CallbackContext context)
    {
        if(context.performed && !isMenuOpen)
        {
            cursorManager.GetComponent<CursorHide>().HideAndCenterCursor(false);
            isMenuOpen = true;
        }
        else if(context.performed && isMenuOpen)
        {
            cursorManager.GetComponent<CursorHide>().HideAndCenterCursor(true);
            isMenuOpen = false;
        }
    }
}