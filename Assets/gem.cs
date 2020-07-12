using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gem : MonoBehaviour
{
    float rotationSpeed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0, Space.Self);
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Points>().points += 100;//Give Player Points
        }
    }
}
