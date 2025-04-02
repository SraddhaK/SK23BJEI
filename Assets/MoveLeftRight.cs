using UnityEngine;

public class MoveLeftRight : MonoBehaviour
{
    public float speed = 3f; // Speed of the movement
    public float resetPositionX = 10f; // X position at which the cube will reset

    void Update()
    {
        // Move the cube continuously to the right along the X-axis
        transform.position += Vector3.right * speed * Time.deltaTime;

        // Reset the position once the cube moves past the reset position
        if (transform.position.x > resetPositionX)
        {
            transform.position = new Vector3(-resetPositionX, transform.position.y, transform.position.z); // Reset to starting position on the left
        }
    }
}