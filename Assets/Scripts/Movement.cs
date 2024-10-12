using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpSpeed = 0f;
    public SpriteRenderer Jeff;
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        if (Jeff.GetComponent<SpriteRenderer>().enabled == false)
        {
            {
                if (Input.GetKey("space"))
                {
                    rb.velocity = Vector2.up * jumpSpeed;
                    animator.SetBool("isJumping", true);

                    if (rb.GetComponent<BoxCollider2D>().enabled == false)
                    {
                        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                    }
                }
                else
                    animator.SetBool("isJumping", false);
            }
        }
        else
        {
            if (Input.GetKey("return"))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }
}
