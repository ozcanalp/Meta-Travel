using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReceptionistSkills : MonoBehaviour
{
    private float distance;
    private GameObject receptionist;
    private Quaternion defaultRotation;
    private float turnSpeed = 2;

    private void Awake()
    {
        receptionist = GameObject.Find("Receptionist");
        defaultRotation = receptionist.transform.rotation;
    }

    private void Update()
    {
        distance = Vector3.Distance(this.transform.position, receptionist.transform.position);

        if(distance <= 6.5f)
        {
            receptionist.transform.LookAt(this.transform);
        }
        else
        {
            receptionist.transform.rotation = Quaternion.Slerp(receptionist.transform.rotation, defaultRotation, turnSpeed * Time.deltaTime);
        }
    }
}
