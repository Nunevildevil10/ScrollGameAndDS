using UnityEngine;

public class SantaManager : MonoBehaviour
{

    public Animator sanataAnimator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
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
}
