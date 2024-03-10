using UnityEngine;

public class Spinner : MonoBehaviour
{
    public float rotationSpeed = 5.0f; // Adjust the rotation speed

    void Update()
    {
        // Rotate the object continuously around the y-axis
        transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
    }
}
