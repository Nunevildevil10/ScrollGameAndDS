using UnityEngine;

public class Santa_Movement : MonoBehaviour
{
    float jumpForce;
    private Rigidbody2D rd2d;
    public Animator Santa_animator;
    public bool IsGrounded;

    void Start()
    {
        IsGrounded = true;
        rd2d = GetComponent<Rigidbody2D>();
        jumpForce = 5f;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            Jump();
        }
    }

    void Jump()
    {
        if (IsGrounded) 
        {
            IsGrounded = false;
            rd2d.linearVelocity = Vector2.up * jumpForce;
            Santa_animator.SetTrigger("Santa_Jump");
        }

    }
}
