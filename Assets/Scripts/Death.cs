using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public Rigidbody2D rb;
    public SpriteRenderer Jeff;
    [HideInInspector] public bool player = true;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Death")
        {
            if(Random.Range(1,20) == 3)
            {
               Jeff.GetComponent<SpriteRenderer>().enabled = true;
               AudioManager.instance.Play("JumpScare");
            }
           
            rb.GetComponent<SpriteRenderer>().enabled = false;
            rb.GetComponent<BoxCollider2D>().enabled = false;
            player = false;
        }
    }
}
