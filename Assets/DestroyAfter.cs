using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfter : MonoBehaviour
{
    [SerializeField] float _timeToDelete;

	private void Start()
	{
		Destroy(gameObject, _timeToDelete);
	}
}
