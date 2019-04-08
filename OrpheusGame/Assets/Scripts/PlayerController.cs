using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public Text text;
    public Vector3 jump;
    Vector3 velocity;
    public float jumpVelocity = 2.0f;
    public float moveSpeed;
    Rigidbody2D rb;
    public Collider2D playerCollider;
    public LayerMask ground;
    public Animator animator;
    float initX;

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
    public void DashDown()
    {
        rb.velocity = new Vector2(rb.velocity.x, -10);
    }
    // Update is called once per frame
    void Update()
    {
        moveSpeed = Globals.instance.tempo / 10;

        text.text = "SCORE: " + rb.transform.position.x;
        rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Item"))
        {
            Destroy(collision.gameObject);
            rb.AddForce(Vector2.right * 10000f);
        }
    }
}