using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class rifleMovement : MonoBehaviour
{
    //private PlayerInput playerInput;
    public GameObject Player;
    public float rotationSpeed =1.0f;
    [SerializeField] FixedJoystick _joystick;
	//public float rotationSmoothness = 20f;

	void Start() {
        //playerInput=GetComponent<PlayerInput>();
    }

    void Update()
    {
        //Vector2 movementInput = playerInput.actions["move"].ReadValue<Vector2>();
        
        if (_joystick.Vertical != 0 ||_joystick.Horizontal != 0)
		{
float targetRotationY = Mathf.Rad2Deg*Mathf.Atan2(_joystick.Vertical, _joystick.Horizontal);
			//float targetRotationY = Mathf.Rad2Deg * Mathf.Atan2(1,  1);
			//Debug.Log(targetRotationY);
            Quaternion targetRotation = Quaternion.Euler(0f, -targetRotationY+90, 0f);
            float t = rotationSpeed * Time.deltaTime;
            Quaternion smoothedRotation = Quaternion.LerpUnclamped(Player.transform.rotation,targetRotation, t);
			Player.transform.rotation = smoothedRotation;
			//Debug.Log(smoothedRotation.y);
			//if(smoothedRotation.y>=-58.744&&smoothedRotation.y<=58.744){
			//    Player.transform.rotation = smoothedRotation;
			//}
		}
    }
}
