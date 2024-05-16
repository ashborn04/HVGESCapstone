using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float moveSpeed = 2f;
    public float leftLimit = -2.0f; // Leftmost position
    public float rightLimit = 2.0f; // Rightmost position
    private int direction = 1; // Initial movement direction (1 for right, -1 for left)

    void Update()
    {
        MovePlatform();
    }

    void MovePlatform()
    {
        transform.Translate(Vector3.right * direction * moveSpeed * Time.deltaTime);

        if (transform.position.x >= rightLimit)
        {
            direction = -1; // Change direction to move left when reaching the right limit
        }
        else if (transform.position.x <= leftLimit)
        {
            direction = 1; // Change direction to move right when reaching the left limit
        }
    }
}