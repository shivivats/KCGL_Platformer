using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    Rigidbody2D rb;
    float xInput;

    bool isGrounded;
    
    // Start is called before the first frame update
    void Start()
    {
        xInput = 0.0f;
        rb = gameObject.GetComponent<Rigidbody2D>();
        isGrounded = false;
    }

    // Update is called once per frame
    void Update()
    {
        xInput = Input.GetAxis("Horizontal");

        if(xInput != 0.0f) 
        { 
            Debug.Log(xInput);
        }

        // if xInput, then move the character = xInput * speed
        rb.velocity = new Vector2(xInput * speed, rb.velocity.y);

        if(Input.GetAxis("Jump") > 0f && isGrounded == true)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            isGrounded = false;
        }
    }
}