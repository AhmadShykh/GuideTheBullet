using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncableWall : Walls
{
	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Bullet")
		{
			Rigidbody rigidbody = other.gameObject.GetComponent<Rigidbody>();
			Vector3 reflectionDirection = Vector3.Reflect(rigidbody.velocity.normalized, transform.right);

			// Set the new velocity of the Rigidbody to the reflection direction
			rigidbody.velocity = reflectionDirection * rigidbody.velocity.magnitude;
		}
	}
}
