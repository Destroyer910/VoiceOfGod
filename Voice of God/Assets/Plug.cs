using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plug : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.tag == "Plug")
        {
            gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition | RigidbodyConstraints.FreezeRotation;
            gameObject.transform.position = other.gameObject.transform.GetChild(0).transform.position;
            gameObject.transform.rotation = other.gameObject.transform.GetChild(0).transform.rotation;
        }    
    }
}
