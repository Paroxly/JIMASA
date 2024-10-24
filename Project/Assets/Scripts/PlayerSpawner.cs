using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    public GameObject PlayerPrefab;
    public float SpawningRange;

    private Vector3 RandomSpawningPosition()
    {
        float xPos = Random.Range(transform.position.x - SpawningRange, transform.position.x + SpawningRange);
        float yPos = Random.Range(transform.position.y - SpawningRange, transform.position.y + SpawningRange);

        Vector3 spawningPos = new Vector3(xPos, yPos);

        return spawningPos;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            Instantiate(PlayerPrefab, RandomSpawningPosition(), transform.rotation);
        }
    }
}