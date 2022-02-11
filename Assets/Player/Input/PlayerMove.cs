using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    private Vector2 move;
    private Vector3 movement;
    public CharacterController controller;
    private float walkSpeed = 10f;

    public void OnMoveInput(InputAction.CallbackContext context)
    {
        move = context.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        Movements();
    }

    private void Movements()
    {
        movement = new Vector3(move.x, 0f, move.y);
        controller.Move(movement * walkSpeed * Time.deltaTime);

        if(movement != Vector3.zero)
        {
            transform.forward = movement;
        }
    }
    
}
