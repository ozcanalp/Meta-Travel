using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class ReceptionistSkills : MonoBehaviour
{
    [SerializeField] PhotonView PV;

    private GameObject receptionist1;
    private Quaternion defaultRotation1;
    private float distance1;
    private float turnSpeed = 2;

    private bool firstTime = true;


    private void Awake()
    {
        receptionist1 = GameObject.Find("Receptionist1");
        defaultRotation1 = receptionist1.transform.rotation;
    }

    private void Update()
    {
        if (PV.IsMine)
        {
            FollowReceptionist();
        }
        
    }

    private void FollowReceptionist()
    {
        distance1 = Vector3.Distance(this.transform.position, receptionist1.transform.position);

        if (distance1 <= 7.5f)
        {
            receptionist1.transform.LookAt(this.transform);
            if (firstTime)
            {
                this.GetComponent<ShowReceptionistDialog>().SetShow();
                firstTime = false;
            }
        }
        else
        {
            receptionist1.transform.rotation = Quaternion.Slerp(receptionist1.transform.rotation, defaultRotation1, turnSpeed * Time.deltaTime);
        }
    }
}
