using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{ 
    //Spawn this object
public GameObject spawnObject;

public float maxTime = 5;
public float minTime = 2;

public float SpawningRange;

//current time
private float time;

//The time to spawn the object
private float spawnTime;

void Start()
{
    SetRandomTime();
    time = minTime;
}

    private Vector3 RandomSpawningPosition()
    {
        float xPos = Random.Range(transform.position.x - SpawningRange, transform.position.x + SpawningRange);
        float yPos = Random.Range(transform.position.y - SpawningRange, transform.position.y + SpawningRange);

        Vector3 spawningPos = new Vector3(xPos, yPos);

        return spawningPos;
    }

    void FixedUpdate()
{

    //Counts up
    time += Time.deltaTime;

    //Check if its the right time to spawn the object
    if (time >= spawnTime)
    {
        SpawnObject();
        SetRandomTime();
    }

}


//Spawns the object and resets the time
void SpawnObject()
{
    time = minTime;
        Instantiate(spawnObject, RandomSpawningPosition(), transform.rotation);
    }

//Sets the random time between minTime and maxTime
void SetRandomTime()
{
    spawnTime = Random.Range(minTime, maxTime);
}
 
 }
 