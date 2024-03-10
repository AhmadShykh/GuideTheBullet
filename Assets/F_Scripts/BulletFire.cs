using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class BulletFire : MonoBehaviour
{
	[SerializeField] GameObject Bullet;
	public int magazine = 10;

	public int countMagazine = 0;
	public float projectileSpeed = 10f;

	private List<GameObject> _bullets = new List<GameObject>();

	public void FireBullet(float playerAngle)
	{
		if (countMagazine < magazine)
		{
			GameObject bullet = Instantiate(Bullet, transform.position,Quaternion.Euler(0,0,0));
			Rigidbody rb = bullet.GetComponent<Rigidbody>();
			bullet.GetComponent<DestroyAfter>().SetBulletFire(this);

			_bullets.Add(bullet);
			bullet.transform.localScale = new Vector3(0.3f,0.3f,0.3f);
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
	private void Update()
	{
		if (countMagazine >= magazine && _bullets.Count == 0)
			SceneManager.LoadScene(0);
	}
	public void RemoveThis(GameObject bullet)
	{
		_bullets.Remove(bullet);
	}

}
