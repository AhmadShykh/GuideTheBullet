using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class rifleMovement : MonoBehaviour
{
    private PlayerInput playerInput;
    public GameObject Player;
    public float rotationSpeed =1.0f;
    public float rotationSmoothness = 20f;

    void Start() {
        playerInput=GetComponent<PlayerInput>();
    }

    void Update()
    {
        Vector2 movementInput = playerInput.actions["move"].ReadValue<Vector2>();
        if(movementInput.x>0||movementInput.y>0){
        float targetRotationY = movementInput.x * rotationSpeed;
        Quaternion targetRotation = Quaternion.Euler(0f, targetRotationY, 0f);
        Quaternion smoothedRotation = Quaternion.Lerp(Player.transform.rotation, targetRotation, rotationSmoothness * Time.deltaTime);
        Debug.Log(smoothedRotation.y);
        if(smoothedRotation.y>=-58.744&&smoothedRotation.y<=58.744){
        Player.transform.rotation = smoothedRotation;
        }
}
    }
}
