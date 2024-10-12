using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour
{
    public Rigidbody2D rb;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "OutOfBounds")
        {
            rb.transform.position = new Vector2(9.49f, Random.Range(-8.52f, -2.71f));
        }
    }
}
