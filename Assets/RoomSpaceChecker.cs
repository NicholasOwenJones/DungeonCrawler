using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSpaceChecker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider other)
    {
        Debug.Log("I am in another room");

        if (other.gameObject.tag == "RoomGeom")
        {
            Debug.LogWarning("This room is " + this.gameObject.name + " , " + this.gameObject.tag + ". The other room is " + other.gameObject.name + " " + other.gameObject.tag + ".");
            Destroy(transform.parent.gameObject);
        }

    }
}
