using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class BottleLuck : MonoBehaviour
{
    public float uprightChance = 0.5f; // Probability of landing upright (0.0 - 1.0)

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            float randomValue = Random.value; // Generate a random value between 0.0 and 1.0

            if (randomValue <= uprightChance)
            {
                SetBottleUpright();
            }
            else
            {
                SetBottleFlat();
            }
        }
    }

    void SetBottleUpright()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        GetComponent<Rigidbody2D>().angularVelocity = 0f;
        transform.rotation = Quaternion.identity;
    }

    void SetBottleFlat()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        GetComponent<Rigidbody2D>().angularVelocity = 0f;
        transform.rotation = Quaternion.Euler(0f, 0f, 90f); // Lay the bottle flat on the ground
    }
}