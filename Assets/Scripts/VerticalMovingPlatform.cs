using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalMovingPlatform : MonoBehaviour
{
    public float verticalSpeed = 2f;
    public float verticalRange = 3f;
    private bool isMovingUp = true;

    void Update()
    {
        MovePlatformVertically();
    }

    void MovePlatformVertically()
    {
        if (isMovingUp && transform.position.y >= verticalRange)
        {
            isMovingUp = false;
        }
        else if (!isMovingUp && transform.position.y <= -verticalRange)
        {
            isMovingUp = true;
        }

        if (isMovingUp)
        {
            transform.Translate(Vector3.up * verticalSpeed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.down * verticalSpeed * Time.deltaTime);
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
