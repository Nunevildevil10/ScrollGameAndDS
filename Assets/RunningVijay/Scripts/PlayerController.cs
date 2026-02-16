using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb2d;
    BoxCollider2D bc2d;
    float jumpForce;
    Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        jumpForce = 7f;
        rb2d = GetComponent<Rigidbody2D>();
        //bc2d = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    // Input.GetButtonDown(KeyCode.A
    void Update()
    {
        if ((Input.GetMouseButtonDown(0)))
        {
            //rb2d.linearVelocity = Vector2.up * jumpForce;
            jump();
        }
      }

    void jump()
    {
        rb2d.linearVelocity = Vector2.up * jumpForce;

    }
}
