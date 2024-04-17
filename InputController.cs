using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    Controls controls;

    private void Awake()
    {
        controls = new Controls();
    }

    private void OnEnable()
    {
        controls.Gameplay.Enable();
        controls.Gameplay.Move.performed += OnMove;
    }

    private void OnMove(InputAction.CallbackContext context)
    {
        Vector2 moveInpout = context.ReadValue<Vector2>();
        Debug.Log($"Move Input: {moveInput}");
    }
}
