using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfter : MonoBehaviour
{
    [SerializeField] float _timeToDelete;
	private BulletFire _bulletFire;
	private void Start()
	{
		Invoke("DestroyObject", _timeToDelete);
		
	}

	public void SetBulletFire(BulletFire bulletFire)
	{
		_bulletFire = bulletFire;
	}

	void DestroyObject()
	{
		_bulletFire.RemoveThis(gameObject);
		Destroy(this, 0.01f);
	}
}
