using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawn : MonoBehaviour
{
    public GameObject[] itemsSpawn;

    // Start is called before the first frame update
    void Start()
    {
        int rand = Random.Range(0, itemsSpawn.Length);
        Instantiate(itemsSpawn[rand], gameObject.transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
