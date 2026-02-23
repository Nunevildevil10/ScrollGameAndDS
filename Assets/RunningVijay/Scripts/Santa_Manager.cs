using UnityEngine;

public class Santa_Manager : MonoBehaviour
{
    public Animator Santa_animator;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Santa_animator.SetTrigger("Santa_Run"); 

        if ((Input.GetKeyDown(KeyCode.D)))
        {
            Santa_animator.SetTrigger("Santa_Die");
        }

        else if ((Input.GetKeyDown(KeyCode.I)))
        {
            Santa_animator.SetTrigger("Santa_Ideal");
        }
    }
}
