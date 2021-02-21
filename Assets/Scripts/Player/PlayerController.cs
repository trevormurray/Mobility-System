using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    InputMaster playerControls;

    // On Awake, enable player action methods
    void Awake()
    {
        playerControls = new InputMaster();
        playerControls.Gameplay.Move.performed += context => Move(context.ReadValue<Vector2>());
        playerControls.Gameplay.Look.performed += context => Look(context.ReadValue<Vector2>());
        playerControls.Gameplay.Jump.performed += _ => Jump();
        playerControls.Gameplay.Attack.performed += _ => Attack();
        playerControls.Gameplay.Interact.performed += _ => Interact();
        playerControls.Gameplay.Dash.performed += _ => Dash();
    }

    // Define all player action methods
    //Move
    private void Move(Vector2 direction)
    {
        Debug.Log("Player movement input detected. " + direction);
    }
    //Look
    void Look(Vector2 direction)
    {
        Debug.Log("Camera movement input detected. " + direction);
    }
    //Jump
    void Jump()
    {
        Debug.Log("Jump button input detected.");
    }
    //Attack
    void Attack()
    {
        Debug.Log("Attack button input detected.");
    }
    //Interact
    void Interact()
    {
        Debug.Log("Interact button input detected.");
    }
    //Dash
    void Dash()
    {
        Debug.Log("Dash button input detected.");
    }

    //Enabling and disabling inputs
    private void OnEnable()
    {
        playerControls.Gameplay.Enable();
    }

    private void OnDisable()
    {
        playerControls.Gameplay.Disable();
    }
}
