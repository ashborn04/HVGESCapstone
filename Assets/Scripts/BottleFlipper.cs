using System.Collections;
using System.Collections.Generic;
// using UnityEngine;

// public class BottleFlipper : MonoBehaviour
// {
//     public float flipForce = 10f;
//     public float jumpForce = 5f;
//     private bool isLeftClicked = false;
//     private bool isRightClicked = false;
//     private float clickTimeThreshold = 0.5f; // Time threshold for double-click
//     private float lastClickTime = 0f;
//     AudioManager audioManager;
//      private void Awake()
//     {
//         audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
//     }

//     void Update()
//     {
        
//         if (Input.GetMouseButtonDown(0)) // Left mouse button
//         {
            
//             if (Time.time - lastClickTime <= clickTimeThreshold)
//             {
//                 if (!isLeftClicked)
//                 {
//                     isLeftClicked = true;
//                     FlipBottleLeft();
//                 }
//                 else
//                 {
//                     isLeftClicked = false;
//                 }
//             }
//             else
//             {
//                 isLeftClicked = false;
//             }
//             lastClickTime = Time.time;
//         }
//         else if (Input.GetMouseButtonDown(1)) 
//         // Right mouse button
//         {
            
//             if (Time.time - lastClickTime <= clickTimeThreshold)
//             {
//                 if (!isRightClicked)
//                 {
//                     isRightClicked = true;
//                     FlipBottleRight();
//                 }
//                 else
//                 {
//                     isRightClicked = false;
//                 }
//             }
//             else
//             {
//                 isRightClicked = false;
//             }
//             lastClickTime = Time.time;
//         }
//     }

//     void FlipBottleLeft()
//     {
//         audioManager.PlaySFX(audioManager.flipping);
//         GetComponent<Rigidbody2D>().AddTorque(flipForce, ForceMode2D.Impulse);
//         GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
//         GetComponent<Rigidbody2D>().AddForce(Vector2.left * flipForce, ForceMode2D.Impulse);
//     }

//     void FlipBottleRight()
//     {
//         audioManager.PlaySFX(audioManager.flipping);
//         GetComponent<Rigidbody2D>().AddTorque(-flipForce, ForceMode2D.Impulse);
//         GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
//         GetComponent<Rigidbody2D>().AddForce(Vector2.right * flipForce, ForceMode2D.Impulse);
//     }
// }

using UnityEngine;

public class BottleFlipper : MonoBehaviour
{
    public float flipForce = 10f;
    public float jumpForce = 5f;
    private bool isLeftClicked = false;
    private bool isRightClicked = false;
    private float clickTimeThreshold = 0.5f; // Time threshold for double-click
    private float lastClickTime = 0f;
    AudioManager audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
         DontDestroyOnLoad(gameObject);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (Time.time - lastClickTime <= clickTimeThreshold)
            {
                if (!isLeftClicked)
                {
                    isLeftClicked = true;
                    FlipBottleLeft();
                }
                else
                {
                    isLeftClicked = false;
                }
            }
            else
            {
                isLeftClicked = false;
            }
            lastClickTime = Time.time;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (Time.time - lastClickTime <= clickTimeThreshold)
            {
                if (!isRightClicked)
                {
                    isRightClicked = true;
                    FlipBottleRight();
                }
                else
                {
                    isRightClicked = false;
                }
            }
            else
            {
                isRightClicked = false;
            }
            lastClickTime = Time.time;
        }
    }

    public void FlipBottleLeft()
    {
        audioManager.PlaySFX(audioManager.flipping);
        GetComponent<Rigidbody2D>().AddTorque(flipForce, ForceMode2D.Impulse);
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        GetComponent<Rigidbody2D>().AddForce(Vector2.left * flipForce, ForceMode2D.Impulse);
    }

    public void FlipBottleRight()
    {
        audioManager.PlaySFX(audioManager.flipping);
        GetComponent<Rigidbody2D>().AddTorque(-flipForce, ForceMode2D.Impulse);
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        GetComponent<Rigidbody2D>().AddForce(Vector2.right * flipForce, ForceMode2D.Impulse);
    }
}