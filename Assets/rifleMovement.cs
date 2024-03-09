using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class rifleMovement : MonoBehaviour
{
    private PlayerInput playerInput;
    public GameObject Player;
    public float rotationSpeed =200.0f;

    void Start() {
        playerInput=GetComponent<PlayerInput>();
    }

    void Update()
    {
        Vector2 movementInput = playerInput.actions["move"].ReadValue<Vector2>();
        float deadZoneThreshold = 0.1f; // Adjust dead zone size
        if (Mathf.Abs(movementInput.x) < deadZoneThreshold &&
            Mathf.Abs(movementInput.y) < deadZoneThreshold)
        {
            return;
        }
        float targetRotationY = movementInput.x * rotationSpeed;
        float targetRotationX = -movementInput.y * rotationSpeed;


        Quaternion yRotation = Quaternion.Euler(targetRotationX, targetRotationY, 0f);
        Player.transform.rotation = yRotation.normalized;

        Debug.Log(targetRotationY);
        Debug.Log(targetRotationX);

        // Apply smooth rotation with RotateTowards (optional)
        // transform.rotation = Quaternion.RotateTowards(transform.rotation, yRotation, rotationSpeed * Time.deltaTime);
    }
}
