using UnityEngine;

public class MoveObstacal : MonoBehaviour
{
    float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        speed = -3f;
    }

    // Update is called once per frame
    void Update()
    {
        if (!PlayerController.Instance.isGameOver)
            transform.position = new Vector3(this.transform.position.x + speed * Time.deltaTime, this.transform.position.y, this.transform.position.z);
    }
}
