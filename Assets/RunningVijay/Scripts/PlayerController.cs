using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [Header("Settings")]
    public float jumpForce = 12f;

    private Rigidbody2D rb;
    private bool isGrounded = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Check for Spacebar or Mouse Click
        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) && isGrounded)
        {
            // Apply the upward force
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);

            // We just jumped, so we aren't on the ground anymore!
            isGrounded = false;
        }
    }

    // This detects when Sanda lands back on the invisible platform
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}