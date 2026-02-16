using UnityEngine;

public class Santa_Movement : MonoBehaviour
{
    float jumpForce;
    private Rigidbody2D rd2d;

    void Start()
    {
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
        rd2d.linearVelocity = Vector2.up * jumpForce;
    }
}
