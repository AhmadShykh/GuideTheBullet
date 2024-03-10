using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using Unity.VisualScripting;
using UnityEngine;

public class BulletFire : MonoBehaviour
{
	[SerializeField] GameObject Bullet;
	public int magazine = 10;

	public int countMagazine = 0;
	public float projectileSpeed = 10f;

	public void FireBullet(float playerAngle)
	{
		if (countMagazine < magazine)
		{
			GameObject bullet = Instantiate(Bullet, transform.position,Quaternion.Euler(0,0,0));
			Rigidbody rb = bullet.GetComponent<Rigidbody>();
			bullet.transform.localScale = new Vector3(0.5f,0.5f,0.5f);
			// Check if the rigidbody component exists
			if (rb != null)
			{
				// Calculate the direction to shoot b
				// ased on the parent object's forward direction
				//Vector3 shootDirection = playerLoc;
				// Calculate the directional vector using trigonometry
				// Apply force to shoot the projectile in the calculated direction
				// Calculate the directional vector using trigonometry
				playerAngle = Mathf.Deg2Rad*(playerAngle+90);
				Vector3 forceDirection = new Vector3(Mathf.Cos(playerAngle), 0f, Mathf.Sin(playerAngle));

				Debug.Log($"{playerAngle} {forceDirection}");
				//Debug.Log(_bulletHole.position);
				rb.AddForce(forceDirection, ForceMode.VelocityChange);
			}
			else
				Debug.Log("RigidBody On Bullet Does not Exists");
			countMagazine++;
		}
	}

}
