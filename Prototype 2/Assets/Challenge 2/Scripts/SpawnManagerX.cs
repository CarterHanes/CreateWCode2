using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{ 
    public GameObject[] ballPrefabs;

private float spawnLimitXLeft = -22;
private float spawnLimitXRight = 7;
private float spawnPosY = 30;
private float timer = 4;

private void Start()
{
    
}

// Spawn random ball at random x position at top of play area
void SpawnRandomBall()
{
    if (timer <= 0)
    {
        int index = Random.Range(0, ballPrefabs.Length);

        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[index], spawnPos, ballPrefabs[index].transform.rotation);

        timer = Random.Range(3, 6);
        
    }
    else timer -= Time.deltaTime;
}

void Update()
{
    SpawnRandomBall();
}
}