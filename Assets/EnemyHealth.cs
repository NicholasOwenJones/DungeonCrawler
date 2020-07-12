using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public GameObject[] loot;
    public float enemyHealth = 120;
    public GameObject enemy;

    private void Update()
    {
        enemy = gameObject;
        if (enemyHealth <= 0)
        {
            int rand = Random.Range(0, loot.Length);
            Instantiate(loot[rand], enemy.transform);
            Instantiate(loot[rand], enemy.transform);
            Dead();
        } 
    }

    private void Dead()
    {
        Destroy(gameObject);
    }
}
