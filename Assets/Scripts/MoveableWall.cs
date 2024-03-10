using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class MoveableWall : Walls
{
	[Header("Wall Moving Configrations")]
	[SerializeField] float _wallSpeed;
	[SerializeField] float _minZValue;
	[SerializeField] float _maxZValue;

    public MoveableWall()
    {
		
    }

    void Update()
	{
		if (Input.GetMouseButton(0))
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit raycastHit;

			if (Physics.Raycast(ray, out raycastHit, Mathf.Infinity))
			{
				if(raycastHit.collider.gameObject == gameObject &&raycastHit.point.z > _minZValue && raycastHit.point.z < _maxZValue) {
					transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x, transform.position.y, raycastHit.point.z), _wallSpeed * Time.deltaTime);
				}
			}
		}
	}

	private void OnTriggerEnter(Collider collider)
	{
		if (collider.gameObject.tag == "Bullet")
		{
			collision.gameObject.GetComponent<DestroyAfter>().DestroyObject();
		}
	}
}
