using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log(gameObject.name + " is attacking the player.");
            other.gameObject.GetComponent<Health>().health -= 10;
            other.gameObject.GetComponent<Health>().CurrentHealth();
            Destroy(gameObject);
        }
    }
}
