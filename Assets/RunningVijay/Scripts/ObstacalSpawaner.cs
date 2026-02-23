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

        InvokeRepeating(nameof(SpawnObstacals),0f, 4f);
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
        Instantiate(enamyPrefabs[num], new Vector3(spawnerPoint.position.x, spawnerPoint.position.y, 0f), Quaternion.identity);
    }
}
