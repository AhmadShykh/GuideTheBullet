using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyScript : MonoBehaviour
{
	bool dead = false;
	private void OnTriggerEnter(Collider other)
	{
		if(!dead && other.tag == "Ball")
		{
			dead = true;
			Destroy(gameObject,2);
			SceneManager.LoadScene("Level 2");
		}
	}
}