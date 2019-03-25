using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Vector3 jump;
    public float jumpForce = 2.0f;

    [SerializeField]
    Rigidbody2D rb;

    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
    }
    public void Jump()
    {
        Debug.Log("jumping");
        rb.AddForce(jump * jumpForce, ForceMode2D.Impulse);
    }
    // Update is called once per frame
    void Update()
    {
    
    }


    private void FixedUpdate()
    {

    }
}
