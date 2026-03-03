using UnityEngine;

public class SantaManager : MonoBehaviour
{

    public Animator sanataAnimator;
    public PlayerController playerController;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sanataAnimator.Play("ASantaRun");
    }

    // Update is called once per frame
    void Update()
    {

       // if (sanataAnimator != null) { 

        if ((Input.GetKeyDown(KeyCode.R)))
        {
            // Playing animation by trigger  >>> pass trigger name
            //sanataAnimator.SetTrigger("SantaRun");
            // Playing animation by clip  >>> pass clip name
                Debug.Log("Run");
                sanataAnimator.Play("ASantaRun");
        }
        else if ((Input.GetKeyDown(KeyCode.D)))
        {
            //sanataAnimator.SetTrigger("SantaDead");
            sanataAnimator.Play("ASentaDead");
            }
        else if ((Input.GetKeyDown(KeyCode.J)))
        {
            //sanataAnimator.SetTrigger("SantaJump");
                sanataAnimator.Play("ASantaJump");
            }
        else if ((Input.GetKeyDown(KeyCode.I)))
        {
            //sanataAnimator.SetTrigger("SantaIdle");
                sanataAnimator.Play("ASantaIdle");
            }
     //  }
    }


    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            sanataAnimator.Play("ASentaDead");

            //playerController.isGameOver = true;
            PlayerController.Instance.isGameOver = true;

            //Invoke(nameof(GameOver), 0.4f);
        }
        else if (collision.gameObject.CompareTag("Ground"))
        {
            //playerController.isGrounded = true;
            PlayerController.Instance.isGrounded = true;
        }
    }

    private void GameOver()
    {
        Time.timeScale = 0.2f;
    }
}
