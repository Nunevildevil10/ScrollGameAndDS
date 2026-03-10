using UnityEngine;

public class move_obstacal : MonoBehaviour
{
    

     float speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        speed = -5f;
    } 

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(this.transform.position.x + speed * Time.deltaTime, this.transform.position.y, this.transform.position.z);
    }
}
