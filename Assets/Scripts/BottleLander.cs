using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleLander : MonoBehaviour
{
    AudioManager audioManager;
    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            audioManager.PlaySFX(audioManager.landing);
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            GetComponent<Rigidbody2D>().angularVelocity = 0f;
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}