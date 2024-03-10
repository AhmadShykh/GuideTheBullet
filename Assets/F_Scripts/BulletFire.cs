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
				playerAngle = Mathf.Deg2Rad*(playerAngle+90);
				Vector3 forceDirection = new Vector3(Mathf.Cos(playerAngle), 0f, Mathf.Sin(playerAngle));
				rb.AddForce(forceDirection, ForceMode.VelocityChange);
			}
			else
				Debug.Log("RigidBody On Bullet Does not Exists");
			countMagazine++;
		}
	}

}
