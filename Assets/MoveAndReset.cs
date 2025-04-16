using UnityEngine;

public class MoveAndReset : MonoBehaviour
{
    public float speed = 3f; // Speed of movement
    public float resetPositionX = -10f; // Position where the object will reset
    public float startPositionX = 0f; // Initial position before the movement starts

    void Start()
    {
        // Set the initial position of the object
        transform.position = new Vector3(startPositionX, transform.position.y, transform.position.z);
    }

    void Update()
    {
        // Move the object forward along the x-axis
        transform.Translate(Vector3.down * speed * Time.deltaTime);

        // Check if the object has moved past the reset point
        if (transform.position.x <= resetPositionX)
        {
            // Reset the object's position to the start position
            transform.position = new Vector3(startPositionX, transform.position.y, transform.position.z);
        }
    }
}