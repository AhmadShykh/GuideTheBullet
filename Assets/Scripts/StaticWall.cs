using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticWall : Walls
{
	private void OnTriggerEnter(Collider collision)
	{
		if (collision.gameObject.tag == "Bullet") {
			collision.gameObject.GetComponent<DestroyAfter>().DestroyObject();
		}
	}
}
