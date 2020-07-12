using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallGenerator : MonoBehaviour
{
    public GameObject[] wallSpawn;

    // Start is called before the first frame update
    void Start()
    {
        int rand = Random.Range(0, wallSpawn.Length);
        Instantiate(wallSpawn[rand], gameObject.transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
