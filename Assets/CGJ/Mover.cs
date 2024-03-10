using UnityEngine;

public class Mover : MonoBehaviour
{
    public float speed = 2.0f; // Adjust the speed of the movement
    public Vector3 offset = new Vector3(0.0f, 0.0f, 0.0f); // Adjust the offset vector

    void Update()
    {
        // Calculate the horizontal movement using the sin function
        float movement = Mathf.Sin(Time.time * speed);

        // Set the new position of the transform with the offset
        transform.position = new Vector3(transform.position.x + offset.x, transform.position.y + offset.y, movement + offset.z);
    }
}
