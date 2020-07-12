using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] enemies;

    public GameObject player;

    public float spawnRange = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }
    }

    void Update()
    {
        float dist = Vector3.Distance(gameObject.transform.position, player.transform.position);
        if (dist < spawnRange)
        {
            int rand = Random.Range(0, enemies.Length);
            Instantiate(enemies[rand], gameObject.transform.position, Quaternion.identity);
            //Instantiate(enemies[rand], gameObject.transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
