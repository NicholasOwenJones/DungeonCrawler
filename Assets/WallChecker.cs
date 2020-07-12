using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallChecker : MonoBehaviour
{
    public Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("wall"))
        {
            Debug.Log("This is a wall");
            rend = other.gameObject.GetComponent<Renderer>();
            rend.enabled = false;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("wall"))
        {
            Debug.Log("This is a wall");
            rend = other.gameObject.GetComponent<Renderer>();
            rend.enabled = true;
        }
    }
}
