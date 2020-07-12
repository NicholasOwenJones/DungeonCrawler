using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject player, attack;

    public float chasingRange = 5.0f, moveSpeed = 2.0f, attackRange = 3.0f;

    public float timeRemaining = 35.0f;

    private bool attacking;

    // Start is called before the first frame update
    void Start()
    {
        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }

        attacking = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float dist = Vector3.Distance(gameObject.transform.position, player.transform.position);
        if(dist < chasingRange)
        {
            Debug.Log( gameObject.name + " is chasing the player.");
            gameObject.transform.LookAt(player.transform);
            //gameObject.transform.Rotate(90, 0, 90, Space.Self);
            transform.position += transform.forward * moveSpeed * Time.deltaTime; ;
        }
        if (dist < attackRange)
        {if (!attacking)
            {
                Instantiate(attack, gameObject.transform);
                attacking = true;
            }
        }
        if (attacking)
        {
            timeRemaining -= Time.deltaTime;
            if (timeRemaining < 0)
            {
                attacking = false;
            }
        }
    }
}
