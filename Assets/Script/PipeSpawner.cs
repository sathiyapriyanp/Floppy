using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject PipePrefab;
    public float SpawnRate = 3;
    public float timer = 0;
    public float highestOffset = 10;
    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < SpawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnPipe();

            timer = 0;
        }

    }
    void spawnPipe()
    {
        float lowestPoint = transform.position.y - highestOffset;
        float highestPoint = transform.position.y + highestOffset;
        Instantiate(PipePrefab, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);

    }
}
