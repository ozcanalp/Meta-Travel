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


    private void Update()
    {
        if (Physics.Raycast(this.transform.position, this.transform.TransformDirection(Vector3.forward), out raycastHit, raycastLength, layerMask.value))
        {
            crossHair.GetComponent<Image>().color = Color.yellow;
            crossHair.transform.localScale = new Vector3(0.6f, 0.6f, 0.6f);
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
