using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{

    public GameObject[] obstacles;
    Vector3 spawnPos;
    public float spawnRate;

    // Start is called before the first frame update
    void Start()
    {
        spawnPos = transform.position;

        //Spawn();

        StartCoroutine("SpawnObstacles");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnObstacles()
    {
        while (true)
        {
            Spawn();

            yield return new WaitForSeconds(spawnRate);
        }
    }

    void Spawn(){
        int randObstacle = Random.Range(0, obstacles.Length);

        Instantiate(obstacles[randObstacle], spawnPos, transform.rotation);
    }
}
