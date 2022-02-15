using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Photon.Pun;

public class ReceptionistSkills : MonoBehaviour
{
    private float distance1;
    private GameObject receptionist1;
    private Quaternion defaultRotation1;
    [SerializeField] PhotonView PV;
    private float turnSpeed = 2;
    private bool firstTime = true;
    private float showTime = 0f;
    //private TextMeshProUGUI txt;

    private void Awake()
    {
        receptionist1 = GameObject.Find("Receptionist1");
        //txt = receptionist1.GetComponentInChildren<TextMeshProUGUI>();
        defaultRotation1 = receptionist1.transform.rotation;
    }

    private void Update()
    {
        if (PV.IsMine)
        {
            distance1 = Vector3.Distance(this.transform.position, receptionist1.transform.position);

            if (distance1 <= 7.5f)
            {
                receptionist1.transform.LookAt(this.transform);
                if (firstTime)
                {
                    showTime = 20f;
                    firstTime = false;
                }
            }
            else
            {
                receptionist1.transform.rotation = Quaternion.Slerp(receptionist1.transform.rotation, defaultRotation1, turnSpeed * Time.deltaTime);
            }

            //if (showTime > 0)
            //{
            //    showTime -= Time.deltaTime;
            //    if (showTime < 5f)
            //    {
            //        txt.text = "baris";
            //    }
            //    else if (showTime < 10f)
            //    {
            //        txt.text = "efe";
            //    }
            //    else if (showTime < 15f)
            //    {
            //        txt.text = "sadsda";
            //    }
            //}
        }
        
    }
}
