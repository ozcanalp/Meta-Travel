using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class GhostHat : MonoBehaviour
{
    [SerializeField] PhotonView PV;
    [SerializeField] GameObject hatFront;
    [SerializeField] GameObject hatTop;


    void Start()
    {
        if (PV.IsMine)
        {
            hatFront.gameObject.layer = 8;
            hatTop.gameObject.layer = 8;
        }
    }

    
}
