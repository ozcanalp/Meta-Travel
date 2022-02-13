using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorHide : MonoBehaviour
{
    private void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void HideAndCenterCursor(bool hide)
    {
        if (hide)
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            
        }
        else if (!hide)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            
        }
    }
}
