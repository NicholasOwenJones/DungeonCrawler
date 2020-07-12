using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateFirball : MonoBehaviour
{
    public GameObject FireBall, player;
    public int totalBalls = 2;
    private int fireballs;

    // Start is called before the first frame update
    void Start()
    {
        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }

        Instantiate(FireBall, gameObject.transform); //new Vector3(player.transform.localPosition.x, player.transform.localPosition.y, player.transform.localPosition.z + 3f), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if (fireballs <= totalBalls)
        {
            Instantiate(FireBall, gameObject.transform);
            fireballs +=1;
        }
    }
}
