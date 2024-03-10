using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfter : MonoBehaviour
{
    [SerializeField] float _timeToDelete;
	private BulletFire _bulletFire;
	private bool destroyed = false;
	private void Start()
	{
		Invoke("DestroyObject", _timeToDelete);
		
	}

	public void SetBulletFire(BulletFire bulletFire)
	{
		_bulletFire = bulletFire;
	}

	public void DestroyObject()
	{
		if(!destroyed)
		{
			destroyed = true;
			_bulletFire.RemoveThis(gameObject);
			Destroy(gameObject, 0.01f);
		}
		
	}
}
