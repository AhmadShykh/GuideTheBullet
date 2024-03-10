using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RifleScript : MonoBehaviour
{
    [SerializeField] Button _fireBtn;
    [SerializeField] BulletFire _fireBullet;
    [SerializeField] TextMeshProUGUI _levelText; 
    public GameObject Player;
    public float rotationSpeed =1.0f;
    [SerializeField] FixedJoystick _joystick;


    private float _playerRotation = 90;

	private void Start()
	{
        _levelText.text = string.Format($"Level: {SceneManager.GetActiveScene().buildIndex}");
        _fireBtn.onClick.AddListener(FireBtnClickFunc);
	}

	void Update()
    {
        
        if (_joystick.Vertical != 0 ||_joystick.Horizontal != 0)
		{
			_playerRotation = Mathf.Rad2Deg*Mathf.Atan2(_joystick.Vertical, _joystick.Horizontal);
            Quaternion targetRotation = Quaternion.Euler(0f, -_playerRotation+90, 0f);
            float t = rotationSpeed * Time.deltaTime;
            Quaternion smoothedRotation = Quaternion.LerpUnclamped(Player.transform.rotation,targetRotation, t);
			Player.transform.rotation = smoothedRotation;
		}
    }

    void FireBtnClickFunc()
    {

        _fireBullet.FireBullet(_playerRotation);
    }

}
