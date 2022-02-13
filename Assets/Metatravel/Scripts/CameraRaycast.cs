using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraRaycast : MonoBehaviour
{
    private float raycastLength = 7;
    private RaycastHit raycastHit;
    [SerializeField] LayerMask layerMask;
    public bool isHitButton;
    [SerializeField] GameObject crossHair;
    public GameObject whichButton;


    private void Update()
    {
        if (Physics.Raycast(this.transform.position, this.transform.TransformDirection(Vector3.forward), out raycastHit, raycastLength, layerMask.value))
        {
            crossHair.GetComponent<Image>().color = Color.yellow;
            isHitButton = true;
            whichButton = raycastHit.transform.gameObject;
        }
        else
        {
            crossHair.GetComponent<Image>().color = Color.white;
            isHitButton = false;
        }
    }
}
