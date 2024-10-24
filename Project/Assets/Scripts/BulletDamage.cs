using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDamage : MonoBehaviour
{

public float bulletDamage;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            other.gameObject.GetComponent<EnemyHealth>().damageEnemy(bulletDamage);
            Destroy(gameObject);
        }

        if (other.gameObject.tag == "Level")
        {
            Destroy(gameObject);
        }

        if (other.gameObject.tag == "Item")
        {
            Destroy(gameObject);
        }
    }
}
