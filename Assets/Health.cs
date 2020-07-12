using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public GameObject player;

    public float health, currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }

        health = 100;
    }

    // Update is called once per frame
    void Update()
    {
        if(player.transform.position.y <= -2)
        {
            health = 0;
        }

        if (health <= 0)
        {
            Death();
        }
    }

    public void CurrentHealth()
    {
        Debug.Log("The players current health is " + health + ".");
    }

    public void Death() //The players Death.
    {
        Debug.LogWarning("YOU ARE DEAD!");
        //Go to Death Screen. Then Main Menu.
    }
}
