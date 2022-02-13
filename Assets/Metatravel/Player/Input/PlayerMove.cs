using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    private Vector2 move;
    private Vector3 movement;
    private float walkSpeed = 6f;
    private Rigidbody rigidBody;

    private void Start() {
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

        Movements();
    }

    private void Movements()
    {
        //movement = new Vector3(move.x, 0f, move.y);
        movement = transform.right * move.x + transform.forward * move.y;
        //controller.Move(movement * walkSpeed * Time.deltaTime);
        rigidBody.MovePosition(transform.position + movement * walkSpeed * Time.deltaTime);
    }
    
}
