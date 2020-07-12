using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Space_Checker : MonoBehaviour
{
    public void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "RoomGeom" || collision.gameObject.tag == "room" || collision.gameObject.tag == "checker")
        {
            Destroy(transform.parent.gameObject);
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "RoomGeom" || collision.gameObject.tag == "room" || collision.gameObject.tag == "checker")
        {
            Destroy(transform.parent.gameObject);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "RoomGeom" || other.gameObject.tag == "room" || other.gameObject.tag == "checker")
        {
            Destroy(transform.parent.gameObject);
        }
    }

    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "RoomGeom" || other.gameObject.tag == "room" || other.gameObject.tag == "checker")
        {
            Destroy(transform.parent.gameObject);
        }
    }
}
