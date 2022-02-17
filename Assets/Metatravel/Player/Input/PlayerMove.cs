using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Photon.Pun;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] PhotonView PV;

    private Vector2 move;
    private Vector3 movement;
    private float walkSpeed = 6f;
    private Rigidbody rigidBody;


    private void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    public void OnMoveInput(InputAction.CallbackContext context)
    {
        move = context.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        if (this.GetComponent<PlayerMenu>().isMenuOpen)
            return;

        if (PV.IsMine)
        {
            Movements();
        }
    }

    private void Movements()
    {
        movement = transform.right * move.x + transform.forward * move.y;
        rigidBody.MovePosition(transform.position + movement * walkSpeed * Time.deltaTime);
    }

}
