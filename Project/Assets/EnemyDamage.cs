using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public int damage;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<PlayerHealth>().damagePlayer(damage);
        }

        if (other.gameObject.tag == "KillBox")
        {
            Destroy(gameObject);
        }
    }
}
