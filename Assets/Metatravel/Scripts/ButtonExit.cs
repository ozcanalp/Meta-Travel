using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonExit : MonoBehaviour
{
    public bool close = false;

    public void ExitComputer()
    {
        close = true;
    }

    public void SetCloseFalse()
    {
        close = false;
    }

    public bool GetCloseFalse()
    {
        return close;
    }
}
