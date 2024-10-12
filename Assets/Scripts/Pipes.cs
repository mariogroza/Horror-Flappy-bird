using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    public Rigidbody2D rb;
    public Rigidbody2D Player;
    public float moveSpeed = 0f;
    private void FixedUpdate()
    {
        if (Player.GetComponent<BoxCollider2D>().enabled == true)
        {
            rb.velocity = Vector2.left * moveSpeed;
        }
        else
        {
            rb.velocity = Vector2.left * 0;
        }
    }
}
