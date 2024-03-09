using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class rifleMovement : MonoBehaviour
{
    public GameObject Player;
    public float rotationSpeed =1.0f;
    [SerializeField] FixedJoystick _joystick;
	
    void Update()
    {
        
        if (_joystick.Vertical != 0 ||_joystick.Horizontal != 0)
		{
            float targetRotationY = Mathf.Rad2Deg*Mathf.Atan2(_joystick.Vertical, _joystick.Horizontal);
			Quaternion targetRotation = Quaternion.Euler(0f, -targetRotationY+90, 0f);
            float t = rotationSpeed * Time.deltaTime;
            Quaternion smoothedRotation = Quaternion.LerpUnclamped(Player.transform.rotation,targetRotation, t);
			Player.transform.rotation = smoothedRotation;
		}
    }
}
