using UnityEngine;

public class PlayOnStart : MonoBehaviour
{
  public AudioSource audioSource;

  void Update()
  {
    if (audioSource != null)
    {
      Debug.Log("Hello");
      audioSource.Play();
    }
  }
}