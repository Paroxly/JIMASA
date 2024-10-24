using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float health;
    public float currentHealth;
    private ItemDrop getItem;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = health;
        getItem = GetComponent<ItemDrop>();
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth <= 0)
        {
            if (getItem != null)
            {
                getItem.DropItem();
                Debug.Log("Dropped an Item: " + getItem);
            }
            Destroy(gameObject);
        }
    }

    public void damageEnemy(float damage)
    {
        currentHealth -= damage;
    }
}