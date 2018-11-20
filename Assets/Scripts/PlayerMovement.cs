using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public float speed;
    Rigidbody2D rb;
    [SerializeField]
    float JumpTime;
    public float StartJumpTime;
    public float JumpForce;
    public float checkRad;
    public Transform checkPos;
    public LayerMask ground;
    public bool IsGrounded;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        JumpTime = StartJumpTime;
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        bool IsGrounded = Physics2D.OverlapCircle(checkPos.position, checkRad, ground);
        float h = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(h * speed, rb.velocity.y);
        if (JumpTime <= 0 && IsGrounded == true)
        {
            if (Input.GetButton("Jump"))
            {
                rb.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);
            }
            JumpTime = StartJumpTime;
        }
        else
        {
            JumpTime -= Time.deltaTime; 
        }
	}
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawSphere(checkPos.position, checkRad);
    }
}
