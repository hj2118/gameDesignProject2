using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class PlayerCode : MonoBehaviour
{
    public Transform feet;
    public LayerMask ground;
    public float speed = 10;
    public int jumpForce = 500;
    float groundCheckDist = 0.5f;
    bool grounded = false;
    Rigidbody2D body;
    
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        grounded = Physics2D.OverlapCircle(feet.position, groundCheckDist, ground);
        if (grounded && Input.GetKeyDown("space"))
        {
            body.AddForce(transform.up * jumpForce);
        }
    }

    void Update()
    {
        
    }
}
