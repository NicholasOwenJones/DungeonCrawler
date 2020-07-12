using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireUp : MonoBehaviour
{
    public float thrust = 50.0f;
    public Rigidbody rb;
    public float timeRemaining = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {


    }

    void FixedUpdate()
    {
        rb.AddForce(transform.up * thrust);
        rb.AddForce(-transform.forward * thrust);
        timeRemaining -= Time.deltaTime;
        if (timeRemaining < 0)
        {
            Dead();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Enemy Taking Damage");
            other.gameObject.GetComponent<EnemyHealth>().enemyHealth -= 10;
            Dead();
        }
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<Health>().health -= 5;
            Dead();
        }

    }

    public void Dead()
    {
        Destroy(gameObject);
    }
}
