using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NearLogoRotation : MonoBehaviour
{
    [Range(1,10)]
    [SerializeField] int rotateSpeed = 1;

    void Update()
    {
        transform.Rotate(Vector3.up * rotateSpeed * 10 * Time.deltaTime, Space.World);
    }

}
