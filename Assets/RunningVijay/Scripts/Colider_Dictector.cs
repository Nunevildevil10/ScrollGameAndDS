using UnityEngine;

public class Colider_Dictector : MonoBehaviour
{

    public Animator Santa_animator;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Player hit Enemy!");
            Santa_animator.SetTrigger("Santa_Die"); 
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
