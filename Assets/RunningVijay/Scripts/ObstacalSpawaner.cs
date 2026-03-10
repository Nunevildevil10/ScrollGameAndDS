using UnityEngine;

public class ObstacalSpawaner : MonoBehaviour
{
    //public GameObject enamyPrefabs;
    public Transform spawnerPoint;
    public GameObject[] enamyPrefabs;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // Made by Unity
    void Start()
    {
        //SpawnObstacals();

        InvokeRepeating(nameof(SpawnObstacals), 1f, Random.Range(2f , 3f));
    }

    // Update is called once per frame
    //Made by Unity
    void Update()
    {
       
    }


    //Made by User
    public void SpawnObstacals()
    {
        // Spawn single boject
        //Instantiate(enamyPrefabs , new Vector3(spawnerPoint.position.x, spawnerPoint.position.y, spawnerPoint.position.z), Quaternion.identity);

        // Spawn Random Objects

        int num = Random.Range(0, enamyPrefabs.Length);
        

        Instantiate(enamyPrefabs[num], new Vector3(spawnerPoint.position.x, spawnerPoint.position.y, spawnerPoint.position.z), Quaternion.identity);
    }
}

public class EnemyChase : MonoBehaviour
{
    public float speed = 5f;
    private Transform player;

    void Start()
    {
        // Find player (tag your Santa GameObject as "Player")
        GameObject playerObj = GameObject.FindGameObjectWithTag("Player");
        if (playerObj != null)
        {
            player = playerObj.transform;
        }
    }

    void Update()
    {
        if (player == null) return;

        // Move toward player position
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(
            transform.position,
            player.position,
            step
        );

        // Destroy if too far (performance)
        if (Vector3.Distance(transform.position, player.position) > 30f)
        {
            Destroy(gameObject);
        }
    }
}