using UnityEngine;

public class Colider_Dictector : MonoBehaviour
{

    public Animator Santa_animator;
    public Santa_Movement santa_Movement;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Player hit Enemy!");
            Santa_animator.SetTrigger("Santa_Die"); 
        }

       else if (collision.gameObject.CompareTag("Ground"))
       {
           IsGrounded = true; 
       }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
