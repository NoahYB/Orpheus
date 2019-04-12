using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public Text text;
    public Vector3 jump;
    public float timeToJumpApex;
    public float gravity;
    public float dashDownVelocity =  -10f;
    Vector3 velocity;
    public float jumpVelocity = 2.0f;
    public float moveSpeed;
    public float t;
    Rigidbody2D rb;
    public Collider2D playerCollider;
    public LayerMask ground;
    public Animator animator;
    float initX;
    Controller2DOrpheus controller;
    // Start is called before the first frame update
    void Start()
    {
        t = Globals.tempo/80;
        controller = GetComponent <Controller2DOrpheus>();
        jumpVelocity = gravity * timeToJumpApex;
        animator = GetComponent<Animator>();
        playerCollider = GetComponent<Collider2D>();
        animator.SetBool("isWalking", true);
    }
    public void Jump()
    {
        velocity.y = jumpVelocity;
    }
    public void DashDown()
    {
        velocity.y = dashDownVelocity;
    }
    // Update is called once per frame
    void Update()
    {
        t = Globals.tempo / 80;

        velocity.x = moveSpeed * t;
        velocity.y += ((gravity * -1) * Time.deltaTime);

        if (controller.collisions.above || controller.collisions.below)
        {
            velocity.y = 0;
        }
        Vector2 input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));


        if (transform.position.y < -20)
        {

        }

        controller.Move(velocity);

    }
}
