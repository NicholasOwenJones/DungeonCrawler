using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonGenerator : MonoBehaviour
{
    public GameObject[] room1, room2, room3, rooms_in_scene, roomWalls;

    public int roomCount = 40;

    private GameObject[] roomClamps, walls;

    // Start is called before the first frame update
    void Start()
    {
        //the stating random room from room1
        int rand = Random.Range(0, room1.Length);
        Instantiate(room1[rand], transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rooms_in_scene = GameObject.FindGameObjectsWithTag("room"); //checks for how many rooms in the scene.
        if (rooms_in_scene.Length <= roomCount) //stops producing rooms if more than roomCount.
        {
            roomClamps = GameObject.FindGameObjectsWithTag("roomClamp"); //looks for spaces to place the rooms
            if (roomClamps.Length > 0) //attaches a random room if there is a roomClamp avalible
            {
                foreach (GameObject go in roomClamps) //the random room from room 2
                {
                    int rand = Random.Range(0, room2.Length);
                    Instantiate(room2[rand], go.transform.position, Quaternion.identity);
                    Debug.Log("");
                    Destroy(go);
                }
            }
        }
        else //puts in the final rooms from room3.
        {
            roomClamps = GameObject.FindGameObjectsWithTag("roomClamp");
            if (roomClamps.Length > 0)
            {
                foreach (GameObject go in roomClamps)
                {
                    int rand = Random.Range(0, room3.Length);
                    Instantiate(room3[rand], go.transform.position, Quaternion.identity);
                    Destroy(go);
                }
            }
            else
            {
                roomClamps = GameObject.FindGameObjectsWithTag("roomClamp");
                if (roomClamps.Length == 0)
                {
                    Walls();
                }
            }
        }
    }

    void Walls()
    {
        walls = GameObject.FindGameObjectsWithTag("wallClamp");
        foreach (GameObject wall in walls)
        {
            int rand = Random.Range(0, roomWalls.Length);
            Instantiate(roomWalls[rand], wall.transform.position, Quaternion.identity);
            Destroy(wall);
        }
    }
}
