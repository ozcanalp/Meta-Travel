using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraRaycast : MonoBehaviour
{
    private float raycastLength = 5;
    private RaycastHit raycastHit;
    [SerializeField] LayerMask layerMask;
    public bool isHitButton;
    [SerializeField] GameObject crossHair;
    public GameObject whichButton;
    [SerializeField] GameObject mainCamera;


    private void Update()
    {
        if (Physics.Raycast(mainCamera.transform.position, mainCamera.transform.TransformDirection(Vector3.forward), out raycastHit, raycastLength, layerMask.value))
        {
            crossHair.GetComponent<Image>().color = Color.yellow;
            crossHair.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
            isHitButton = true;
            whichButton = raycastHit.transform.gameObject;
        }
        else
        {
            crossHair.GetComponent<Image>().color = Color.white;
            crossHair.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
            isHitButton = false;
        }
    }
}
