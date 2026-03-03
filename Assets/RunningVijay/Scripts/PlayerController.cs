using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb2d;
    BoxCollider2D bc2d;
    float jumpForce;
    Animator animator;

    public bool isGrounded;
    public bool isGameOver;

    public static PlayerController Instance;

    private void Awake()
    {
        //if (Instance == null)
        Instance = this;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isGrounded = true;
        isGameOver = false;
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
        if (isGrounded && !isGameOver)
        {
            isGrounded = false;
            rb2d.linearVelocity = Vector2.up * jumpForce;
        }

    }
}
