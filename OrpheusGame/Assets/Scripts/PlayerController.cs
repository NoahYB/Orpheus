using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Vector3 jump;
    Vector3 velocity;
    public float jumpVelocity = 2.0f;
    public float moveSpeed = 1.0f;
    Rigidbody2D rb;
    public Collider2D playerCollider;
    public LayerMask ground;
    public Animator animator;
    

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        playerCollider = GetComponent<Collider2D>();
        rb = GetComponent<Rigidbody2D>();
        animator.SetBool("isWalking", true);
    }
    public void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpVelocity);

    }
    // Update is called once per frame
    void Update()
    {

        rb.velocity = new Vector2(moveSpeed, rb.velocity.y);

        //if (Input.GetKeyDown(KeyCode.Space) && Physics2D.IsTouchingLayers(playerCollider,ground))
        //{

        //    Jump();
        //}
    }


    private void FixedUpdate()
    {

    }
}
