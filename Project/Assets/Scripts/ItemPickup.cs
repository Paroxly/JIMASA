using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{

    public float delay = 0f;
    public int score;

    void Update()
    {
        decay();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<PlayerScore>().incScore(score);
            Destroy(gameObject);
        }
    }

    void decay()
    {
        Destroy(gameObject, delay);
    }
}