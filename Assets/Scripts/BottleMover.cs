using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleMover : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Left mouse button
        {
            MoveBottleLeft();
        }
        else if (Input.GetMouseButtonDown(1)) // Right mouse button
        {
            MoveBottleRight();
        }
    }

    void MoveBottleLeft()
    {
        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
    }

    void MoveBottleRight()
    {
        transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
    }
}