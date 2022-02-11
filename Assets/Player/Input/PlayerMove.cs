using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    private Vector2 move;
    private Vector3 movement;
    public CharacterController controller;
    private float walkSpeed = 12f;

    public void OnMoveInput(InputAction.CallbackContext context)
    {
        move = context.ReadValue<Vector2>();
        
    }

    private void FixedUpdate()
    {
        Movements();
        AddGravity();
    }

    private void Movements()
    {
        //movement = new Vector3(move.x, 0f, move.y);
        movement = transform.right * move.x + transform.forward * move.y;
        controller.Move(movement * walkSpeed * Time.deltaTime);
    }

    private void AddGravity()
    {
        controller.Move(Physics.gravity * Time.deltaTime);
    }
    
}
