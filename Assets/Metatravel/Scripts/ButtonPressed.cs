using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPressed : MonoBehaviour
{
    private float buttonSpeed = 2;
    [SerializeField] GameObject redButton;

    public void Pressed()
    {
        redButton.transform.position = redButton.transform.position + new Vector3(0f, 1f * buttonSpeed * Time.deltaTime, 0f);
    }
}
