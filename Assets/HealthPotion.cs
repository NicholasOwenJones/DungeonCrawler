using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPotion : MonoBehaviour
{
    public int rotationSpeed = 8;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0, Space.Self);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<Player_Fire>().AddItem();
            other.gameObject.GetComponent<Health>().health+=10;
            other.gameObject.GetComponent<Health>().CurrentHealth();
            Destroy(gameObject);
        }
    }
}
