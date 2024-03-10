using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAbleWall : MonoBehaviour
{
    private bool _destroyed = false;

	private void OnTriggerEnter(Collider other)
	{
		if(!_destroyed && other.tag == "Bullet")
		{
			other.gameObject.GetComponent<DestroyAfter>().DestroyObject();
			_destroyed = true;
			Destroy(gameObject, 0.01f);
		}
	}
}
