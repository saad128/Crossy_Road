using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] obstaclePrefabs;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", 1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {


    }

    void SpawnObstacle()
    {
        
        int obstacleIndex = Random.Range(0, obstaclePrefabs.Length);
        Instantiate(obstaclePrefabs[obstacleIndex], transform.position, obstaclePrefabs[obstacleIndex].transform.rotation);
    }
}
