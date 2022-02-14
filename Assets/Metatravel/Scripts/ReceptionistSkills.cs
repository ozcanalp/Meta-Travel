using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReceptionistSkills : MonoBehaviour
{
    private float distance1;
    private GameObject receptionist1;
    private Quaternion defaultRotation1;

    private float distance2;
    private GameObject receptionist2;
    private Quaternion defaultRotation2;

    private float turnSpeed = 2;

    private void Awake()
    {
        receptionist1 = GameObject.Find("Receptionist1");
        defaultRotation1 = receptionist1.transform.rotation;
        receptionist2 = GameObject.Find("Receptionist2");
        defaultRotation2 = receptionist2.transform.rotation;
    }

    private void Update()
    {
        //Receptionist#1
        distance1 = Vector3.Distance(this.transform.position, receptionist1.transform.position);

        if(distance1 <= 5f)
        {
            receptionist1.transform.LookAt(this.transform);
        }
        else
        {
            receptionist1.transform.rotation = Quaternion.Slerp(receptionist1.transform.rotation, defaultRotation1, turnSpeed * Time.deltaTime);
        }

        //Receptionist#2
        distance2 = Vector3.Distance(this.transform.position, receptionist2.transform.position);

        if (distance2 <= 5f)
        {
            receptionist2.transform.LookAt(this.transform);
        }
        else
        {
            receptionist2.transform.rotation = Quaternion.Slerp(receptionist2.transform.rotation, defaultRotation2, turnSpeed * Time.deltaTime);
        }
    }
}
