using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float platformSpeed = 2f;
    public float platformRange = 3f;
    private bool isMovingRight = true;

    void Update()
    {
        MovePlatform();
    }

    void MovePlatform()
    {
        if (isMovingRight && transform.position.x >= platformRange)
        {
            isMovingRight = false;
        }
        else if (!isMovingRight && transform.position.x <= -platformRange)
        {
            isMovingRight = true;
        }

        if (isMovingRight)
        {
            transform.Translate(Vector3.right * platformSpeed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.left * platformSpeed * Time.deltaTime);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.transform.SetParent(transform);
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.transform.SetParent(null);
        }
    }
}
