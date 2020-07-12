using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move : MonoBehaviour
{
    public GameObject player;

    public float forwardSpeed = 10.0f, sidewaysSpeed = 10.0f, forward, sideways; 

    // Start is called before the first frame update
    void Start()
    {
        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }
    }

    // Update is called once per frame
    void Update()
    {
        forward = Input.GetAxis("Vertical") * forwardSpeed;
        sideways = -Input.GetAxis("Horizontal") * sidewaysSpeed;

        forward *= Time.deltaTime;
        sideways *= Time.deltaTime;

        transform.Translate(forward, 0, sideways);
    }
}
