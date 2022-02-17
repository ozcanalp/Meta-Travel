using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class CameraRaycast : MonoBehaviour
{
    [SerializeField] PhotonView PV;

    [SerializeField] GameObject crossHair;
    [SerializeField] GameObject mainCamera;
    [SerializeField] LayerMask layerMask;
    public GameObject whichButton;
    private RaycastHit raycastHit;
    private float raycastLength = 5;
    public bool isHitButton;


    private void Update()
    {
        if (PV.IsMine)
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
}
