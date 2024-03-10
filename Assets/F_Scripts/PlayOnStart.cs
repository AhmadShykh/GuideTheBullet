using Unity.VisualScripting;
using UnityEngine;

public class PlayOnStart : MonoBehaviour
{
	static PlayOnStart instance;
	private void Start()
	{
		if (instance == null)
		{
			instance = this;	
			DontDestroyOnLoad(gameObject);
		}
		else
		{
			Destroy(gameObject);	
		}	
	}


	//void Update()
	//{
	//  if (audioSource != null)
	//  {
	//    Debug.Log("Hello");
	//    audioSource.Play();
	//  }
	//}
}